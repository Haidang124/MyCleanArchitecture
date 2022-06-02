using MediatR;
using MyCleanArchitecture.Application.Interfaces.Responses.Users;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query.Users
{
    public class UserLoginRequest : IRequest<UserLoginResponse>
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}