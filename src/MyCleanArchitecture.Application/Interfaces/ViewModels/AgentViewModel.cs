namespace MyCleanArchitecture.Application.Interfaces.ViewModels
{
    public class AgentViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}