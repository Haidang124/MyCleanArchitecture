using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;

namespace MyCleanArchitecture.Application.CQRSHandler.Query.Users
{
    public class UserLoginHandler : IRequestHandler<UserLoginRequest, Guid>
    {
        public Task<Guid> Handle(UserLoginRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}