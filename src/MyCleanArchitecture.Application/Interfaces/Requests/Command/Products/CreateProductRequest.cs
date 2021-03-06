using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
using MyCleanArchitecture.DomainShare.Objects;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Command.Products
{
    public class CreateProductRequest : IRequest<ProductViewModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int NumberProduct { get; set; }
        public List<Image> Images { get; set; }
        public Guid AgentId { get; set; }
        public Guid ProductLineId { get; set; }
    }
}