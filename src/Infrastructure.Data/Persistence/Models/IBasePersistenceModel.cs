using MyCleanArchitecture.Domain.Common;

namespace Infrastructure.Data.Persistence.Models
{
    public interface IBasePersistenceModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }

    }
}