using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models.Agents;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.entities.User;

namespace Infrastructure.Data.Persistence.Models
{
    public abstract class BasePersistenceModel : IBasePersistenceModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public abstract IAggregateRoot ToEntity();
        public BasePersistenceModel FromEntity(IAggregateRoot root)
        {
            var mapper = new Dictionary<Type, Func<IAggregateRoot, BasePersistenceModel>>
            {
                //  {typeof(UserEntity), (r) => { return new User((UserEntity) r); } },
            };
            return mapper[root.GetType()](root);
        }
    }
}
