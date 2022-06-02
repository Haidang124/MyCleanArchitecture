using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Command.Products
{
    public class CreateProductLineRequest : IRequest<ProductLineViewModel>
    {
        public Guid ProductLineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}