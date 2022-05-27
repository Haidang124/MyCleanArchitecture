using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models.Products;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;

namespace Infrastructure.Data.Persistence.Models.Agents
{
    public class AgentProduct : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid AgentId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal buyprice { get; set; }
        public virtual Product Product { get; set; }
        public virtual Agent Agent { get; set; }
        public AgentProduct() { }
        public AgentProduct(AgentProductEntity agentProductEntity)
        {
            Id = agentProductEntity.Id;
            AgentId = agentProductEntity.AgentId;
            ProductId = agentProductEntity.ProductId;
            Quantity = agentProductEntity.Quantity;
            buyprice = agentProductEntity.buyprice;
        }
        public override IAggregateRoot ToEntity()
        {
            return new AgentProductEntity()
            {
                Id = this.Id,
                AgentId = this.AgentId,
                ProductId = this.ProductId,
                Quantity = this.Quantity,
                buyprice = this.buyprice
            };
        }

    }
}
