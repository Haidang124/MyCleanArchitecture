using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanArchitecture.Application.Common;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Products;
using MyCleanArchitecture.Application.Interfaces.Requests.Query;
using MyCleanArchitecture.Application.Interfaces.Requests.Query.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductLineController : Controller
    {
        private readonly IMediator _mediator;
        public ProductLineController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Filter product line 
        /// </summary>
        /// <param name="GetProductLineByFilterRequest"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<ProductLineViewModel> FilterProductLines([FromBody] GetProductLineByFilterRequest request)
        {
            return await _mediator.Send(request);
        }
        /// <summary>
        /// Create a new product line
        /// </summary>
        /// <param name="CreateProductLineRequest"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ProductLineViewModel> CreateProductLine([FromBody] CreateProductLineRequest request)
        {
            return await _mediator.Send(request);
        }

    }
}
