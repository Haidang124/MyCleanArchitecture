using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;

namespace Infrastructure.Data.Persistence.Models.Agents
{
    public class OrderDetail : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public OrderDetail() { }
        public OrderDetail(OrderDetailEntity orderDetailEntity)
        {
            Id = orderDetailEntity.Id;
            OrderId = orderDetailEntity.OrderId;
            ProductId = orderDetailEntity.ProductId;
            Quantity = orderDetailEntity.Quantity;
            UnitPrice = orderDetailEntity.UnitPrice;
        }
        public override IAggregateRoot ToEntity()
        {
            return new OrderDetailEntity()
            {
                Id = this.Id,
                OrderId = this.OrderId,
                ProductId = this.ProductId,
                Quantity = this.Quantity,
                UnitPrice = this.UnitPrice
            };
        }
    }
}
