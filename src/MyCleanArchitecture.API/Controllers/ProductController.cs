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
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Filter products 
        /// </summary>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<ProductViewModel> FilterProducts([FromBody] GetProductByFilterRequest request)
        {
            return await _mediator.Send(request);
        }
        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="CreateProductRequest"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ProductViewModel> Login([FromBody] CreateProductRequest request)
        {
            return await _mediator.Send(request);
        }

    }
}
