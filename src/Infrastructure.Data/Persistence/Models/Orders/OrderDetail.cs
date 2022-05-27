using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Products;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;

namespace Infrastructure.Data.Persistence.Models.Orders
{
    public class OrderDetail : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
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
