using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Users;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace Infrastructure.Data.Persistence.Models.Products
{
    public class WishList : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public WishList() { }
        public WishList(WishListEntity wishListEntity)
        {
            Id = wishListEntity.Id;
            ProductId = wishListEntity.ProductId;
            UserId = wishListEntity.UserId;
        }
        public override IAggregateRoot ToEntity()
        {
            return new WishListEntity()
            {
                Id = this.Id,
                ProductId = this.ProductId,
                UserId = this.UserId
            };
        }
    }
}
