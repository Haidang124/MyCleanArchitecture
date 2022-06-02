using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanArchitecture.Application.Common;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Agents;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Products;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;
using MyCleanArchitecture.Application.Interfaces.Requests.Query.Agents;
using MyCleanArchitecture.Application.Interfaces.Requests.Query.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgentController : Controller
    {
        private readonly IMediator _mediator;
        public AgentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Filter agents 
        /// </summary>
        /// <param name="GetAgentByFilterRequest"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<AgentViewModel> FilterAgents([FromBody] GetAgentByFilterRequest request)
        {
            return await _mediator.Send(request);
        }
        /// <summary>
        /// Create a new agent
        /// </summary>
        /// <param name="CreateAgentRequest"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<AgentViewModel> CreateAgent([FromBody] CreateAgentRequest request)
        {
            return await _mediator.Send(request);
        }

    }
}
