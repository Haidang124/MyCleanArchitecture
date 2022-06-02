using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Orders;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace Infrastructure.Data.Persistence.Models.Products
{
    public class ProductLine : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
        public ProductLine() { }
        public ProductLine(ProductLineEntity productLineEntity)
        {
            Id = productLineEntity.Id;
            Name = productLineEntity.Name;
            Description = productLineEntity.Description;
        }
        public override IAggregateRoot ToEntity()
        {
            return new ProductLineEntity()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }

    }
}
