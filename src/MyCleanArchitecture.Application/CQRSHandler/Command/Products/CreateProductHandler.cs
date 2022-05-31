using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Products
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, ProductViewModel>
    {
        public Task<ProductViewModel> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}