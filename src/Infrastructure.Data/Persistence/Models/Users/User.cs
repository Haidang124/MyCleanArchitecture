using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Blogs;
using Infrastructure.Data.Persistence.Models.Chats;
using Infrastructure.Data.Persistence.Models.Orders;
using Infrastructure.Data.Persistence.Models.Payments;
using Infrastructure.Data.Persistence.Models.Products;
using Microsoft.AspNetCore.Identity;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Domain.DomainModel.entities.User;

namespace Infrastructure.Data.Persistence.Models.Users
{
    public class User : IdentityUser<Guid>, IBasePersistenceModel
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
        public virtual List<Order> Orders { get; set; }
        public virtual List<WishList> WishLists { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public virtual List<Chat> Chats { get; set; }
        public virtual List<Blog> Blogs { get; set; }
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
