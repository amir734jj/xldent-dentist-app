using Api.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Api.Data.Entities;

public sealed class User : IdentityUser<Guid>, IEntity;
