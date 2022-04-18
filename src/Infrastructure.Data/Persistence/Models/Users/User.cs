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
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public override IAggregateRoot ToEntity()
        {
            return new UserEntity()
            {
                Id = this.Id,
                UserName = this.UserName,
                Email = this.Email,
                Password = this.Password,
                LastName = this.LastName,
                FirstName = this.FirstName,
                PhoneNumber = this.PhoneNumber,
                Address = this.Address,
                DOB = this.DOB
            };
        }

    }
}
