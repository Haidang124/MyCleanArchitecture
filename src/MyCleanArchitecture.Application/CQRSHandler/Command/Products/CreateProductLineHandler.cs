using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Products
{
    public class CreateProductLineHandler : IRequestHandler<CreateProductLineRequest, ProductLineViewModel>
    {
        public Task<ProductLineViewModel> Handle(CreateProductLineRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}