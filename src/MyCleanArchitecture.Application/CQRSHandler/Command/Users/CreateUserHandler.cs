using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Infrastructure.CrossCutting.Auth.Jwt;
using Infrastructure.CrossCutting.Settings;
using Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.Extensions.Options;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Users;
using MyCleanArchitecture.Application.Interfaces.Responses.Users;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
using MyCleanArchitecture.Domain.DomainModel.entities.User;
using MyCleanArchitecture.Domain.IRepositories;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Users
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, UserLoginResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly Authenticator _authenticator;
        private readonly AppSettings _appSettings;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUserRepository userRepository, Authenticator authenticator, IOptions<AppSettings> appSettings, IMapper mapper)
        {
            _userRepository = userRepository;
            _authenticator = authenticator;
            _appSettings = appSettings.Value;
            _mapper = mapper;
        }
        public Task<UserLoginResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUserByUsername(request.UserName);
            if (user != null) throw new ArgumentException($"User name {request.UserName} is already taken");
            _authenticator.ValidatePassword(request.Password);
            user = new UserEntity(request.UserName, request.Email, request.Password, request.LastName, request.FirstName, request.PhoneNumber, request.Address, request.DOB);
            _userRepository.AddUser(
                user,
                request.Password
            );
            return Task.FromResult(new UserLoginResponse
            {
                Token = _authenticator.GenerateJsonWebToken(
                    user,
                   _appSettings.Jwt.Key,
                _appSettings.Jwt.Issuer
                ),
                User = _mapper.Map<UserViewModel>(user)
            });
        }
    }

}
