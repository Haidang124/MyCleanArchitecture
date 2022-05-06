using Infrastructure.CrossCutting.Auth.Jwt;
using Infrastructure.CrossCutting.Settings;
using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;
using MyCleanArchitecture.Application.Interfaces.Responses.Users;

namespace MyCleanArchitecture.Application.CQRSHandler.Query.Users
{
    public class UserLoginHandler : IRequestHandler<UserLoginRequest, UserLoginResponse>
    {
        private readonly Authenticator _authenticator;
        private readonly AppSettings _appSettings;

        public UserLoginHandler(Authenticator authenticator, AppSettings appSettings)
        {
            _authenticator = authenticator;
            _appSettings = appSettings;
        }

        public async Task<UserLoginResponse> Handle(UserLoginRequest request, CancellationToken cancellationToken)
        {
            var user = _authenticator.Authenticate(
                 request.UserName,
                 request.Password
             );
            var token = _authenticator.GenerateJsonWebToken(
                user,
                _appSettings.Jwt.Key,
                _appSettings.Jwt.Issuer
            );
            var vm = new UserLoginResponse(token);
            // {
            //    token = token
            // };
            return await Task.FromResult(vm);
            // return new UserLoginResponse(token);
        }
    }
}