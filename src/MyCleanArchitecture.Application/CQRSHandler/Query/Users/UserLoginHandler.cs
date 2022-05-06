using AutoMapper;
using Infrastructure.CrossCutting.Auth.Jwt;
using Infrastructure.CrossCutting.Settings;
using MediatR;
using Microsoft.Extensions.Options;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;
using MyCleanArchitecture.Application.Interfaces.Responses.Users;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Query.Users
{
    public class UserLoginHandler : IRequestHandler<UserLoginRequest, UserLoginResponse>
    {
        private readonly Authenticator _authenticator;
        private readonly AppSettings _appSettings;
        private readonly IMapper _mapper;

        public UserLoginHandler(Authenticator authenticator, IOptions<AppSettings> appSettings, IMapper mapper)
        {
            _authenticator = authenticator;
            _appSettings = appSettings.Value;
            _mapper = mapper;
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
            return await Task.FromResult(new UserLoginResponse
            {
                Token = token,
                User = _mapper.Map<UserViewModel>(user)
            });
        }
    }
}