using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Model;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Payments;

namespace Infrastructure.Data.Persistence.Model.Agents
{
    public class Payment : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Payment() { }
        public Payment(PaymentEntity paymentEntity)
        {
            Id = paymentEntity.Id;
            UserId = paymentEntity.UserId;
            Date = paymentEntity.Date;
            Amount = paymentEntity.Amount;
        }
        public override IAggregateRoot ToEntity()
        {
            return new PaymentEntity()
            {
                Id = this.Id,
                UserId = this.UserId,
                Date = this.Date,
                Amount = this.Amount
            };
        }
    }
}
