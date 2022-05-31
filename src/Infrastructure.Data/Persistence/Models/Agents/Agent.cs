using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;

namespace Infrastructure.Data.Persistence.Models.Agents
{
    public class Agent : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual List<AgentProduct> AgentProducts { get; set; }
        public Agent() { }
        public Agent(AgentEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Description = entity.Description;
            Address = entity.Address;
            Phone = entity.Phone;
            Email = entity.Email;
        }
        public override IAggregateRoot ToEntity()
        {
            return new AgentEntity
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Address = Address,
                Phone = Phone,
                Email = Email
            };
        }

    }
}
