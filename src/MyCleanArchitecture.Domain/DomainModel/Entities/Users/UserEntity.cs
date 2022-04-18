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

    }
}
