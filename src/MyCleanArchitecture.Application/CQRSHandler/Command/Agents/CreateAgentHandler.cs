using AutoMapper;
using MediatR;
using MyCleanArchitecture.Application.Interfaces.Requests.Command.Agents;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;
using MyCleanArchitecture.Domain.IRepositories;

namespace MyCleanArchitecture.Application.CQRSHandler.Command.Agents
{
    public class CreateAgentHandler : IRequestHandler<CreateAgentRequest, AgentViewModel>
    {
        public readonly IAgentRepository _agentRepository;
        public readonly IMapper _mapper;

        public CreateAgentHandler(IAgentRepository agentRepository, IMapper mapper)
        {
            _agentRepository = agentRepository;
            _mapper = mapper;
        }

        public Task<AgentViewModel> Handle(CreateAgentRequest request, CancellationToken cancellationToken)
        {
            AgentEntity agentEntity = new AgentEntity()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email
            };
            _agentRepository.Add(agentEntity);
            return Task.FromResult(_mapper.Map<AgentViewModel>(agentEntity));
        }
    }
}