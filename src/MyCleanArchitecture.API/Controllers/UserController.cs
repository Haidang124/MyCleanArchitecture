using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanArchitecture.Application.Common;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Users;
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
        public ApiResponse<UserLoginResponse> Login()
        {
            var token = "";
            return new ApiResponse<UserLoginResponse>(
                data: new
                {
                    Token = token
                },
                message: "Login success"
            );
        }

        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="CreateUserRequest"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateUserRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
