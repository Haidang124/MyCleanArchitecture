using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Model;
using MyCleanArchitecture.Domain.common;
using MyCleanArchitecture.Domain.DomainModel.entities.User;

namespace Infrastructure.Data.Persistence.Model.Agents
{
    public class User : BasePersistenceModel
    {
        private User root;

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
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

        public override IAggregateRoot ToEntity()
        {
            return new UserEntity(Id, UserName, Email, Password, LastName, FirstName, PhoneNumber, Address, DOB);
        }

    }
}
