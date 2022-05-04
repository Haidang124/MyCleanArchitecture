using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.Common;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Agents
{
    public class AgentEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
