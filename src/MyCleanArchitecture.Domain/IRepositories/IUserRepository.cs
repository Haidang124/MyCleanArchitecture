using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.DomainModel.entities.User;
using MyCleanArchitecture.DomainShare;

namespace MyCleanArchitecture.Domain.IRepositories
{
    public interface IUserRepository
    {
        void AddUser(UserEntity user, string password);
        UserEntity? GetUserByUsername(string username);
        UserEntity? GetUserById(Guid? id);
        UserEntity UpdateProfileUser(UserEntity user);
        Task<bool> ChangePassword(UserEntity userEntity, string password);
        Task RemoveUserById(Guid userId);
    }
}
