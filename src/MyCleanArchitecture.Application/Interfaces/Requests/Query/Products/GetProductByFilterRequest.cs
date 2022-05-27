using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query.Products
{
    public class GetProductByFilterRequest : IRequest<ProductViewModel>
    {

    }
}