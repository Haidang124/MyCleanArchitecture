using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Query.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Query.Products
{
    public class GetProductByFilterHandler : IRequestHandler<GetProductByFilterRequest, ProductViewModel>
    {
        Task<ProductViewModel> IRequestHandler<GetProductByFilterRequest, ProductViewModel>.Handle(GetProductByFilterRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}