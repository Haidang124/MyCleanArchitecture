using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.DomainShare.Objects;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Products
{
    public class ProductEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int QuantityInStock { get; set; }
        public List<Image> Images { get; set; }
        public Guid AgentId { get; set; }
        public Guid ProductLineId { get; set; }
    }
}
