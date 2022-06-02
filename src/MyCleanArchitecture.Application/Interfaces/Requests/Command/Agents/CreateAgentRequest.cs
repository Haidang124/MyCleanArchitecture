using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Command.Agents
{
    public class CreateAgentRequest : IRequest<AgentViewModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}