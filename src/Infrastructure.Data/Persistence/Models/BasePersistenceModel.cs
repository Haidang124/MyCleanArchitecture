using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.common;

namespace Infrastructure.Data.Persistence.Model
{
    public abstract class BasePersistenceModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public abstract IAggregateRoot ToEntity();
        public static BasePersistenceModel FromEntity(IAggregateRoot root)
        {
            var mapper = new Dictionary<Type, Func<IAggregateRoot, BasePersistenceModel>> { };
            return mapper[root.GetType()](root);
        }
    }
}
