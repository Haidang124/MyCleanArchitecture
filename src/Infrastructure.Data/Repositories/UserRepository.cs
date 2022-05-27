using Infrastructure.Data.Persistence.Models;
using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Users;
using Microsoft.AspNetCore.Identity;
using MyCleanArchitecture.Domain.DomainModel.entities.User;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EcommerceDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        public UserRepository(EcommerceDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public void AddUser(UserEntity user, string password)
        {
            var newUser = new User(user);
            var creatingResult = _userManager.CreateAsync(newUser, password).Result;
            if (!creatingResult.Succeeded) throw new ArgumentException("Error creating user");
        }

        public async Task<bool> ChangePassword(UserEntity userEntity, string loginPassword)
        {
            var user = await _dbContext.Users.FindAsync(userEntity.Id);
            if (user == null) throw new ApplicationException("Not found");

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var pwd = await _userManager.ResetPasswordAsync(user, token, loginPassword);
            await _dbContext.SaveChangesAsync();

            return pwd.Succeeded;
        }

        public UserEntity? GetUserById(Guid? id)
        {
            if (id == null) return null;
            var user = _userManager.FindByIdAsync(id.ToString()).Result;
            return user?.ToUser();
        }

        public UserEntity? GetUserByUsername(string username)
        {
            if (username == null) return null;
            var user = _userManager.FindByNameAsync(username).Result;
            return user?.ToUser();
        }

        public async Task RemoveUserById(Guid userId)
        {
            var user = _dbContext.Users.Single(u => u.Id == userId);
            await _userManager.DeleteAsync(user);
        }

        public UserEntity UpdateProfileUser(UserEntity user)
        {
            var data = _dbContext.Users.Single(u => u.Id == user.Id);
            data.FirstName = user.FirstName;
            data.LastName = user.LastName;
            data.Email = user.Email;
            data.PhoneNumber = user.PhoneNumber;
            data.Address = user.Address;
            data.DOB = user.DOB;
            data.UserName = user.UserName;
            _dbContext.SaveChanges();
            return data.ToUser();
        }
    }
}