using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Orders;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace Infrastructure.Data.Persistence.Models.Products
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
        public virtual List<ProductLine> ProductLines { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<AgentProduct> AgentProducts { get; set; }
         public virtual List<WishList> WishLists { get; set; }
        public Product() { }
        public Product(ProductEntity productEntity)
        {
            Id = productEntity.Id;
            Name = productEntity.Name;
            Description = productEntity.Description;
            BuyPrice = productEntity.BuyPrice;
            SellPrice = productEntity.SellPrice;
            QuantityInStock = productEntity.QuantityInStock;
            AgentId = productEntity.AgentId;
            ProductLineId = productEntity.ProductLineId;
        }
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
