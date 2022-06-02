using AutoMapper;
using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Products;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.Domain.IRepositories;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Products
{
    public class CreateProductLineHandler : IRequestHandler<CreateProductLineRequest, ProductLineViewModel>
    {
        public readonly IProductLineRepository _productLineRepository;
        public readonly IMapper _mapper;

        public CreateProductLineHandler(IProductLineRepository productLineRepository, IMapper mapper)
        {
            _productLineRepository = productLineRepository;
            _mapper = mapper;
        }

        public Task<ProductLineViewModel> Handle(CreateProductLineRequest request, CancellationToken cancellationToken)
        {
            ProductLineEntity productLineEntity = new ProductLineEntity()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description
            };
            _productLineRepository.Add(productLineEntity);
            return Task.FromResult(_mapper.Map<ProductLineViewModel>(productLineEntity));
        }
    }
}