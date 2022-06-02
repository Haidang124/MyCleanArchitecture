using MyCleanArchitecture.Domain.DomainModel.Entities.Products;
using MyCleanArchitecture.DomainShare;
using MyCleanArchitecture.DomainShare.Filter;

namespace MyCleanArchitecture.Domain.IRepositories
{
    public interface IProductLineRepository
    {
        PagedAndSortedResult<ProductEntity> GetAllProduct(ProductFilter filter, Pagination pagination);
    }
}