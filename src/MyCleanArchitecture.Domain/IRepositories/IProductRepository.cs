using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace MyCleanArchitecture.Domain.IRepositories
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
    }

}