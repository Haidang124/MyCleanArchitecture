using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query.Users
{
    public class GetProfileUserRequest : IRequest<UserViewModel>
    {
        
    }
}