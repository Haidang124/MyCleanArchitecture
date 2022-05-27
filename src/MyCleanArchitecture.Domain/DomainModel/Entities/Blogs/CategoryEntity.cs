using MyCleanArchitecture.Domain.Common;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Blogs
{
    public class CategoryEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}