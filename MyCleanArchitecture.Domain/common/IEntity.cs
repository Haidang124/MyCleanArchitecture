﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitecture.Domain.common
{
    public interface IEntity
    {
        List<DomainEvent> DomainEvents { get; }
    }

    public interface IEntity<TId> : IEntity
    {
        TId Id { get; }
    }
}
