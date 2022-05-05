using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitecture.Domain.Common
{
    // Apply this marker interface / abstract class only to aggregate root entities
    // Repositories will only work with aggregate roots, not their children
    public abstract class IAggregateRoot : IEntity<Guid>
    {
        public Guid Id { get; protected set; }

        public List<DomainEvent> DomainEvents { get; } = new();
    }
}
