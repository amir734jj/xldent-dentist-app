using Api.Data.Entities;
using EfCoreRepository;

namespace Api.Data.Profiles;

public class UserProfile : EntityProfile<User>
{
    public UserProfile()
    {
        MapAll();
    }
}