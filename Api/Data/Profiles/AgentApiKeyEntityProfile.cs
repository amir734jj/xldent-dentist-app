using Api.Data.Entities;
using EfCoreRepository;

namespace Api.Data.Profiles;

public class AgentApiKeyEntityProfile : EntityProfile<AgentApiKey>
{
    public AgentApiKeyEntityProfile()
    {
        MapAll();
    }
}