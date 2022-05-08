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
            var result = await _mediator.Send(request);
            //return Json(result);
            return result;
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
