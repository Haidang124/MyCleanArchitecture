using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query.Products
{
    public class GetProductLineByFilterRequest : IRequest<ProductLineViewModel>
    {
        public string Name { get; set; }
        public Guid ProductLineId { get; set; }
    }
}