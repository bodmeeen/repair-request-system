using RequestSystem.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RequestSystem.DAL.Repositories.Interfaces
{
    public interface IRepairRequestRepository : IGenericRepository<RepairRequest>
    {
        Task<IEnumerable<RepairRequest>> GetByStatusAsync(string status);
    }
}
