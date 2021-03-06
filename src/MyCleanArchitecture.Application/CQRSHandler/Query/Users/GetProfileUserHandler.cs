using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;
using MyCleanArchitecture.Application.Interfaces.Requests.Query.Users;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Query.Users
{
    public class GetProfileUserHandler : IRequestHandler<GetProfileUserRequest, UserViewModel>
    {
        public Task<UserViewModel> Handle(GetProfileUserRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}