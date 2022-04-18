﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Model;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;

namespace Infrastructure.Data.Persistence.Model.Agents
{
    public class OrderDetail : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
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
