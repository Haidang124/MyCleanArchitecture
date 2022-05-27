using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanArchitecture.Application.Common;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Users;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;
using MyCleanArchitecture.Application.Interfaces.Responses.Users;

namespace MyCleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //private ISender _mediator = null!;

        //public UserController(ISender mediator)
        //{
        //    _mediator = mediator;
        //}

        //protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

        /// <summary>
        /// Login with user name and password
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<UserLoginResponse> Login([FromBody] UserLoginRequest request)
        {
            //return Mediator.Send(request);
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="CreateUserRequest"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<UserLoginResponse> Register([FromBody] CreateUserRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
