using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;

namespace Infrastructure.Data.Persistence.Models.Agents
{
    public class Agent : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Agent() { }
        public Agent(AgentEntity agentEntity)
        {
            Id = agentEntity.Id;
            Name = agentEntity.Name;
            Description = agentEntity.Description;
        }
        public override IAggregateRoot ToEntity()
        {
            return new AgentEntity()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }
    }
}
