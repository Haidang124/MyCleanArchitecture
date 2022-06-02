using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query.Products
{
    public class GetProductByFilterRequest : IRequest<ProductViewModel>
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public Guid ProductLineId { get; set; }
        public Guid AgentId { get; set; }
    }
}