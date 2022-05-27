using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.DomainShare.Enum;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Blogs
{
    public class CommentEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid BlogId { get; set; }
    }
}