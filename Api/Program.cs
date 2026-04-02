using System.Reflection;
using System.Text;
using System.Threading.RateLimiting;
using Api.Data;
using Serilog;
using Api.Data.Entities;
using Api.Hubs;
using Api.Services;
using Api.Utilities;
using EfCoreRepository.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
    .WriteTo.File(
        path: "logs/api-.log",
        rollingInterval: RollingInterval.Day,
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(ConnectionStringUtility.ConnectionStringUrlToPgResource(builder.Configuration.GetValue<string>("DATABASE_URL")!)));

builder.Services
    .AddIdentity<User, Role>(opt =>
    {
        opt.Password.RequiredLength = 8;
        opt.Password.RequireNonAlphanumeric = false;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

 
builder.Services.AddEfRepository<AppDbContext>(x =>
{
    x.Profile(Assembly.GetAssembly(typeof(AppDbContext)));
});

builder.Services
    .AddAuthentication(opt =>
    {
        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
        };
    });

builder.Services.AddAuthorization();
builder.Services.AddRateLimiter(opt =>
{
    opt.AddFixedWindowLimiter("login", w =>
    {
        w.Window            = TimeSpan.FromMinutes(1);
        w.PermitLimit       = 10;
        w.QueueLimit        = 0;
        w.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
    });
    opt.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
});
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
builder.Services.AddSignalR().AddNewtonsoftJsonProtocol();
builder.Services.AddSingleton<AgentRegistry>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "XLDent API", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name         = "Authorization",
        Type         = SecuritySchemeType.Http,
        Scheme       = "bearer",
        BearerFormat = "JWT",
        In           = ParameterLocation.Header
    });
    opt.AddSecurityRequirement(_ => new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecuritySchemeReference("Bearer"),
            []
        }
    });
});

builder.Services.AddCors(opt =>
    opt.AddDefaultPolicy(p => p
        .WithOrigins(
            builder.Configuration.GetSection("Cors:Origins").Get<string[]>()!)
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    // Add LastLoginAt column if upgrading from a schema that predates it (idempotent)
    db.Database.ExecuteSqlRaw("""
        ALTER TABLE "AspNetUsers"
        ADD COLUMN IF NOT EXISTS "LastLoginAt" TIMESTAMP WITH TIME ZONE;
        """);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "XLDent API v1"));
}

app.UseCors();
app.UseRateLimiter();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapHub<AgentHub>("/hubs/agent");

app.Run();
