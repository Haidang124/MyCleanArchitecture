using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Users;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Blogs;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Models.Blogs
{
    public class Comment : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid BlogId { get; set; }
        public virtual User User { get; set; }
        public virtual Blog Blog { get; set; }
        public Comment() { }
        public Comment(CommentEntity commentEntity)
        {
            Id = commentEntity.Id;
            Content = commentEntity.Content;
            UserId = commentEntity.UserId;
            BlogId = commentEntity.BlogId;
        }
        public override IAggregateRoot ToEntity()
        {
            return new CommentEntity()
            {
                Id = this.Id,
                Content = this.Content,
                UserId = this.UserId,
                BlogId = this.BlogId
            };
        }
    }
}