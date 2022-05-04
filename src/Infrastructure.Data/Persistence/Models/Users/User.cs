using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.entities.User;

namespace Infrastructure.Data.Persistence.Models.Agents
{
    public class User : IdentityUser<Guid>, IBasePersistenceModel
    {
        private User root;
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public User() { }
        public User(UserEntity userEntity)
        {
            Id = userEntity.Id;
            UserName = userEntity.UserName;
            Email = userEntity.Email;
            Password = userEntity.Password;
            LastName = userEntity.LastName;
            FirstName = userEntity.FirstName;
            PhoneNumber = userEntity.PhoneNumber;
            Address = userEntity.Address;
            DOB = userEntity.DOB;
        }
        public IAggregateRoot ToEntity()
        {
            return new UserEntity(Id, UserName, Email, Password, LastName, FirstName, PhoneNumber, Address, DOB);
        }
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
