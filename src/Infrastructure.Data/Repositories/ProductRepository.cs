using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Products;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : BaseRepository<ProductEntity, Product>, IProductRepository
    {
        protected ProductRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}