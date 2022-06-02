using AutoMapper;
using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.DomainShare.Objects;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Products
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, ProductViewModel>
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;

        public CreateProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<ProductViewModel> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            ProductEntity productEntity = new ProductEntity()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                BuyPrice = request.BuyPrice,
                SellPrice = request.SellPrice,
                QuantityInStock = request.NumberProduct,
                Images = request.Images,
                AgentId = request.AgentId,
                ProductLineId = request.ProductLineId
            };
            _productRepository.Add(productEntity);
            return Task.FromResult(_mapper.Map<ProductViewModel>(productEntity));
        }
    }
}