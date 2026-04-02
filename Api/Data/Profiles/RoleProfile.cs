using Api.Data.Entities;
using EfCoreRepository;

namespace Api.Data.Profiles;

public class RoleProfile : EntityProfile<Role>
{
    public RoleProfile()
    {
        MapAll();
    }
}