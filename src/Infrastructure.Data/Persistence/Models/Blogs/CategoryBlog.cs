using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Blogs;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Models.Blogs
{
    public class CategoryBlog : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public Guid BlogId { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual Category Category { get; set; }
        public CategoryBlog() { }
        public CategoryBlog(CategoryBlogEntity categoryBlogEntity)
        {
            Id = categoryBlogEntity.Id;
            BlogId = categoryBlogEntity.BlogId;
            CategoryId = categoryBlogEntity.CategoryId;
        }
        public override IAggregateRoot ToEntity()
        {
            return new CategoryBlogEntity()
            {
                Id = this.Id,
                BlogId = this.BlogId,
                CategoryId = this.CategoryId
            };
        }
    }
}