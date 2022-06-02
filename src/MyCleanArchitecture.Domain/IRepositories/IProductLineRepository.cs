using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.DomainShare;
using MyCleanArchitecture.DomainShare.Filter;

namespace MyCleanArchitecture.Domain.IRepositories
{
    public interface IProductLineRepository : IRepository<ProductLineEntity>
    {
        PagedAndSortedResult<ProductEntity> GetAllProduct(ProductFilter filter, Pagination pagination);
    }
}