using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanArchitecture.Application.Common;
using MyCleanArchitecture.Application.Interfaces.Responses.Users;

namespace MyCleanArchitecture.API.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Login with user name and password
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public ApiResponse<UserLoginResponse> Index()
        {
            var token = "";
            return new ApiResponse<UserLoginResponse>(
                data: new
                {
                    token = token
                },
                message: "Login success"
            );
        }
    }
}
