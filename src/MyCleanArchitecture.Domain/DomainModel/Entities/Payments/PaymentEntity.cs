using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.common;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Payments
{
    public class PaymentEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
