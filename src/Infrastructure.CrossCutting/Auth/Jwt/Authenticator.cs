using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Infrastructure.Data.Persistence.Models.Agents;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MyCleanArchitecture.Domain.DomainModel.entities.User;

namespace Infrastructure.CrossCutting.Auth.Jwt
{
    internal class Authenticator : IAuthenticator
    {
        public UserEntity Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Claim> ExtractClaimsFromToken(string token)
        {
            throw new NotImplementedException();
        }

        public string GenerateJsonWebToken(UserEntity user, string key, string issuer)
        {
            throw new NotImplementedException();
        }

        public string GenerateUserToken(UserEntity user, string purpose)
        {
            throw new NotImplementedException();
        }

        public void ValidatePassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUserToken(UserEntity user, string purpose, string token)
        {
            throw new NotImplementedException();
        }
    }
    // internal class Authenticator : IAuthenticator
    // {
    //     private readonly UserManager<User> _userManager;
    //     private readonly AppSettings _appSettings;

    //     public Authenticator(
    //         UserManager<User> userManager,
    //         IOptions<AppSettings> appSettings)
    //     {
    //         _userManager = userManager;
    //         _appSettings = appSettings.Value;
    //     }

    //     public User Authenticate(string username, string password)
    //     {
    //         try
    //         {
    //             var userEntity = _userManager.FindByNameAsync(username).Result;
    //             var match = _userManager.CheckPasswordAsync(userEntity, password).Result;
    //             if (!match) throw new FailAuthenticationAttemptException("Username and password do not match");
    //             return userEntity.ToUser();
    //         }
    //         catch
    //         {
    //             throw new FailAuthenticationAttemptException("Username and password do not match");
    //         }
    //     }

    //     public void ValidatePassword(string password)
    //     {
    //         var messages = new List<string>();
    //         var validators = _userManager.PasswordValidators;
    //         foreach (var validator in validators)
    //         {
    //             var result = validator.ValidateAsync(_userManager, null, password).Result;
    //             if (result.Succeeded) continue;
    //             messages.AddRange(result.Errors.Select(error => error.Description));
    //         }

    //         if (messages.Any())
    //             throw new FailAuthenticationAttemptException(
    //                 $"Password fails the following validations: {messages.Aggregate("", (message, m) => message += $"/n{m}")}");
    //     }

    //     public string GenerateJsonWebToken(User user, string key, string issuer)
    //     {
    //         var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
    //         var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

    //         var token = new JwtSecurityToken(
    //             issuer: issuer,
    //             audience: issuer,
    //             claims: new[]
    //             {
    //                 new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
    //                 new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
    //                 //new Claim(JwtRegisteredClaimNames.Email, user.Email),
    //                 new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString(CultureInfo.InvariantCulture))
    //             },
    //             expires: DateTime.Now.AddDays(3),
    //             signingCredentials: credentials
    //         );

    //         return new JwtSecurityTokenHandler().WriteToken(token);
    //     }

    //     public string GenerateUserToken(User user, string purpose)
    //     {
    //         var userDataModel = _userManager.FindByIdAsync(user.Id.ToString()).Result;
    //         if (user == null) throw new ArgumentNullException($"User {user.Username} not found");
    //         var token = _userManager.GenerateUserTokenAsync(
    //             user: userDataModel,
    //             tokenProvider: "Default",
    //             purpose: purpose
    //         ).Result;
    //         return token;
    //     }

    //     public bool VerifyUserToken(User user, string purpose, string token)
    //     {
    //         var userDataModel = _userManager.FindByIdAsync(user.Id.ToString()).Result;
    //         if (user == null) throw new ArgumentNullException($"User {user.Username} not found");
    //         return _userManager.VerifyUserTokenAsync(
    //             user: userDataModel,
    //             tokenProvider: "Default",
    //             purpose: purpose,
    //             token: token
    //         ).Result;
    //     }

    //     public IEnumerable<Claim> ExtractClaimsFromToken(string token) => ValidateToken(token).Claims;

    //     /// <summary>
    //     /// Validate and return decoded token, throw exceptions if token is invalid
    //     /// </summary>
    //     /// <param name="token"></param>
    //     /// <returns></returns>
    //     private JwtSecurityToken ValidateToken(string token)
    //     {
    //         new JwtSecurityTokenHandler().ValidateToken(token, new TokenValidationParameters
    //         {
    //             ValidateIssuer = true,
    //             ValidateAudience = true,
    //             ValidateLifetime = true,
    //             ValidateIssuerSigningKey = true,
    //             ValidIssuer = _appSettings.Jwt.Issuer,
    //             ValidAudience = _appSettings.Jwt.Issuer,
    //             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Jwt.Key))
    //         }, out var validatedToken);
    //         return validatedToken as JwtSecurityToken;
    //     }
    // }
}
