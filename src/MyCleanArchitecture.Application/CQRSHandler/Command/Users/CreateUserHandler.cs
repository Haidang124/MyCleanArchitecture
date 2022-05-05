using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Users;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Users
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, UserViewModel>
    {
        public Task<UserViewModel> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
