using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.entities.User;

namespace Infrastructure.Data.Persistence.Models.Agents
{
    public sealed class User : IdentityUser<Guid>, IBasePersistenceModel
    {
        // private User root;
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
        public UserEntity ToUser()
        {
            return new UserEntity(Id, UserName, Email, Password, LastName, FirstName, PhoneNumber, Address, DOB);
        }
    }
}
