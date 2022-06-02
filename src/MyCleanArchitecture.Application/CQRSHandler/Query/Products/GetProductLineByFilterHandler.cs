using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Query.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Query.Products
{
    public class GetProductLineByFilterHandler : IRequestHandler<GetProductLineByFilterRequest, ProductLineViewModel>
    {
        public Task<ProductLineViewModel> Handle(GetProductLineByFilterRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}