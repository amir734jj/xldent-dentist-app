using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mappings;

public sealed class AgentApiKeyMapping : IEntityTypeConfiguration<AgentApiKey>
{
    public void Configure(EntityTypeBuilder<AgentApiKey> builder)
    {
        builder.Property(k => k.AgentId).HasMaxLength(100);
        builder.HasIndex(k => k.AgentId).IsUnique();
        builder.HasOne(k => k.User)
               .WithMany()
               .HasForeignKey(k => k.UserId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
