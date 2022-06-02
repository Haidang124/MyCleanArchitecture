using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Blogs;
using Infrastructure.Data.Persistence.Models.Chats;
using Infrastructure.Data.Persistence.Models.Orders;
using Infrastructure.Data.Persistence.Models.Payments;
using Infrastructure.Data.Persistence.Models.Products;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;
using MyCleanArchitecture.Domain.DomainModel.Entities.Blogs;
using MyCleanArchitecture.Domain.DomainModel.Entities.Chats;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;
using MyCleanArchitecture.Domain.DomainModel.Entities.Payments;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace Infrastructure.Data.Persistence.Models
{
    public abstract class BasePersistenceModel : IBasePersistenceModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public abstract IAggregateRoot ToEntity();
        public static BasePersistenceModel FromEntity(IAggregateRoot root)
        {
            var mapper = new Dictionary<Type, Func<IAggregateRoot, BasePersistenceModel>>
            {
                {typeof(AgentEntity), (r) => { return new Agent((AgentEntity) r); } },
                {typeof(AgentProductEntity), (r) => { return new AgentProduct((AgentProductEntity) r); } },
                {typeof(BlogEntity), (r) => { return new Blog((BlogEntity) r); } },
                {typeof(CommentEntity), (r) => { return new Comment((CommentEntity) r); } },
                {typeof(CategoryEntity), (r) => { return new Category((CategoryEntity) r); } },
                {typeof(CategoryBlogEntity), (r) => { return new CategoryBlog((CategoryBlogEntity) r); } },
                {typeof(ChatEntity), (r) => { return new Chat((ChatEntity) r); } },
                {typeof(OrderEntity), (r) => { return new Order((OrderEntity) r); } },
                {typeof(OrderDetailEntity), (r) => { return new OrderDetail((OrderDetailEntity) r); } },
                {typeof(PaymentEntity), (r) => { return new Payment((PaymentEntity) r); } },
                {typeof(ProductEntity), (r) => { return new Product((ProductEntity) r); } },
                {typeof(ProductLineEntity), (r) => { return new ProductLine((ProductLineEntity) r); } },
                {typeof(WishListEntity), (r) => { return new WishList((WishListEntity) r); } },
            };
            return mapper[root.GetType()](root);
        }
    }
}
