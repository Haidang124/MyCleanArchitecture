using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Users;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Models.Orders
{
    public class Order : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public StatusOrder Status { get; set; }
        public Guid UserId { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }
        public Order() { }
        public Order(OrderEntity orderEntity)
        {
            Id = orderEntity.Id;
            Description = orderEntity.Description;
            Date = orderEntity.Date;
            Status = orderEntity.Status;
            UserId = orderEntity.UserId;
        }
        public override IAggregateRoot ToEntity()
        {
            return new OrderEntity()
            {
                Id = this.Id,
                Description = this.Description,
                Date = this.Date,
                Status = this.Status,
                UserId = this.UserId
            };
        }
    }
}
