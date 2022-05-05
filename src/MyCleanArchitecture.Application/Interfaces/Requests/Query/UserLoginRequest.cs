using MediatR;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query
{
    public class UserLoginRequest : IRequest<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}