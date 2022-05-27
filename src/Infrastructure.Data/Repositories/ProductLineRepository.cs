using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Products;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class ProductLineRepository : BaseRepository<ProductLineEntity, ProductLine>, IProductLineRepository
    {
        protected ProductLineRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}