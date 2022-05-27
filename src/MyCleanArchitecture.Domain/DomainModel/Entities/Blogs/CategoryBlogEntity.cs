using MyCleanArchitecture.Domain.Common;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Blogs
{
    public class CategoryBlogEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public Guid BlogId { get; set; }
        public Guid CategoryId { get; set; }
    }
}