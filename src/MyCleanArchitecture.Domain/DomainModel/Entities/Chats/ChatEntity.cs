using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.DomainShare.Enum;

namespace MyCleanArchitecture.Domain.DomainModel.Entities.Chats
{
    public class ChatEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
    }
}