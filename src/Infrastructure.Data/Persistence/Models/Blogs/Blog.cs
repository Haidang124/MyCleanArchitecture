using Infrastructure.Data.Persistence.Models.Users;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Blogs;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Models.Blogs
{
    public class Blog : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid AuthorId { get; set; }
        public Security Security { get; set; }
        public Guid CommentID { get; set; }
        public string Description { get; set; }
        public virtual User Author { get; set; }
        public virtual List<CategoryBlog> CategoryBlog { get; set; }
        public virtual List<Comment> Comment { get; set; }

        public Blog() { }
        public Blog(BlogEntity blogEntity)
        {
            Id = blogEntity.Id;
            Title = blogEntity.Title;
            Content = blogEntity.Content;
            AuthorId = blogEntity.AuthorId;
            Security = (Security)blogEntity.Security;
            CommentID = blogEntity.CommentID;
            Description = blogEntity.Description;
        }
        public override IAggregateRoot ToEntity()
        {
            return new BlogEntity()
            {
                Id = this.Id,
                Title = this.Title,
                Content = this.Content,
                AuthorId = this.AuthorId,
                Security = (Security)this.Security,
                CommentID = this.CommentID,
                Description = this.Description
            };
        }
    }
}