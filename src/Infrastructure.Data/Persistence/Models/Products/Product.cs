using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Model;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace Infrastructure.Data.Persistence.Model.Agents
{
    public class Product : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int QuantityInStock { get; set; }
        public Guid AgentId { get; set; }
        public Guid ProductLineId { get; set; }
        public override IAggregateRoot ToEntity()
        {
            return new ProductEntity()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                BuyPrice = this.BuyPrice,
                SellPrice = this.SellPrice,
                QuantityInStock = this.QuantityInStock,
                AgentId = this.AgentId,
                ProductLineId = this.ProductLineId
            };
        }
    }
}
