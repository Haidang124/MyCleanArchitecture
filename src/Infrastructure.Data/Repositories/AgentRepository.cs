using Infrastructure.Data.Persistence.Models.Agents;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class AgentRepository : BaseRepository<AgentEntity, Agent>, IAgentRepository
    {
        protected AgentRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}