using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Model;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Model.Agents
{
    public class Order : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public StatusOrder Status { get; set; }
        public Guid UserId { get; set; }
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
