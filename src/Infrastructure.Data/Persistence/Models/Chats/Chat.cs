using Infrastructure.Data.Persistence.Models.Users;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.Entities.Blogs;
using MyCleanArchitecture.Domain.DomainModel.Entities.Chats;
using MyCleanArchitecture.DomainShare.Enum;

namespace Infrastructure.Data.Persistence.Models.Chats
{
    public class Chat : BasePersistenceModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Chat() { }
        public Chat(ChatEntity chatEntity)
        {
            Id = chatEntity.Id;
            Content = chatEntity.Content;
            UserId = chatEntity.UserId;
        }
        public override IAggregateRoot ToEntity()
        {
            return new ChatEntity()
            {
                Id = this.Id,
                Content = this.Content,
                UserId = this.UserId
            };
        }
    }
}