using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
namespace MyCleanArchitecture.Application.Interfaces.Responses.Users
{
    public class UserLoginResponse : IResponse
    {
        public string Token { get; set; }
        public UserViewModel User { get; set; }
    }
}
