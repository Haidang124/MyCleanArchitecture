using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.Common;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Agents
{
    public class AgentProductEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public Guid AgentId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal buyprice { get; set; }
    }
}
