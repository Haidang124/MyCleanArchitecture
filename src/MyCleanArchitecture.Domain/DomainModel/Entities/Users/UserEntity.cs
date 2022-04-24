using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.common;

namespace MyCleanArchitecture.Domain.DomainModel.entities.User
{
    public class UserEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public UserEntity(Guid id, string UserName, string Email, string Password, string LastName, string FirstName, string PhoneNumber, string Address, DateTime DOB)
        {
            this.Id = id;
            this.UserName = UserName;
            this.Email = Email;
            this.Password = Password;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.DOB = DOB;
        }
    }
}
