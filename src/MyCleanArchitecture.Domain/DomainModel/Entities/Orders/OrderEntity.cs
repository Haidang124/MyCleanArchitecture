using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.DomainShare.Enum;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Orders
{
    public class OrderEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public StatusOrder Status { get; set; }
        public Guid UserId { get; set; }
    }
}
