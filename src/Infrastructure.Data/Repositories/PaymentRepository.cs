using Infrastructure.Data.Persistence.Models.Agents;
using MyCleanArchitecture.Domain.DomainModel.Entities.Payments;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class PaymentRepository : BaseRepository<PaymentEntity, Payment>, IPaymentRepository
    {
        protected PaymentRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}