using Infrastructure.Data.Persistence.Models.Agents;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class OrderRepository : BaseRepository<OrderEntity, Order>, IOrderRepository
    {
        protected OrderRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}