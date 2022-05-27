using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Blogs;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Models.Blogs
{
    public class Category : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<CategoryBlog> CategoryBlogs { get; set; }
        public Category() {}
        public Category(CategoryEntity categoryEntity)
        {
            Id = categoryEntity.Id;
            Name = categoryEntity.Name;
            Description = categoryEntity.Description;
        }
        public override IAggregateRoot ToEntity()
        {
            return new CategoryEntity()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }

    }
}