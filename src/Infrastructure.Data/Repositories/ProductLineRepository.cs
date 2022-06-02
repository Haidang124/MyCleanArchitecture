using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Products;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.DomainShare;
using MyCleanArchitecture.DomainShare.Filter;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class ProductLineRepository : BaseRepository<ProductLineEntity, ProductLine>, IProductLineRepository
    {
        public readonly EcommerceDbContext _context;
        public ProductLineRepository(EcommerceDbContext context) : base(context)
        {
            _context = context;
        }
        public PagedAndSortedResult<ProductEntity> GetAllProduct(ProductFilter filter, Pagination pagination)
        {
            throw new NotImplementedException();
        }
    }
}