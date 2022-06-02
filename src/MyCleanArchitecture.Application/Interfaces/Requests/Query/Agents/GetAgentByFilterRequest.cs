using MediatR;
using MyCleanArchitecture.Application.Interfaces.ViewModels;

namespace MyCleanArchitecture.Application.Interfaces.Requests.Query.Agents
{
    public class GetAgentByFilterRequest : IRequest<AgentViewModel>
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}