using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.DomainShare.Enum;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Blogs
{
    public class BlogEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public Security Security { get; set; }
        public Guid CommentID { get; set; }
        public string Description { get; set; }
    }
}