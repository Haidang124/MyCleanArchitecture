﻿using MyCleanArchitecture.Domain.DomainModel.entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CrossCutting.Authenticator
{
    public interface IAuthenticator
    {
        UserEntity Authenticate(string username, string password);
        void ValidatePassword(string password);
        string GenerateUserToken(UserEntity user, string purpose);
        bool VerifyUserToken(UserEntity user, string purpose, string token);
        string GenerateJsonWebToken(UserEntity user, string key, string issuer);
        public IEnumerable<Claim> ExtractClaimsFromToken(string token);
    }
}
