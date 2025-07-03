using Microsoft.EntityFrameworkCore;
using RequestSystem.DAL.Data;
using RequestSystem.DAL.Entities;
using RequestSystem.DAL.Repositories.Interfaces;


namespace RequestSystem.DAL.Repositories
{
    public class RepairRequestRepository : GenericRepository<RepairRequest>, IRepairRequestRepository
    {
        public RepairRequestRepository(ApplicationDBContext context) : base(context) { }

        public async Task<IEnumerable<RepairRequest>> GetByStatusAsync(RepairStatus status)
        {
            return await _dbSet.Where(r => r.Status == status).ToListAsync();
        }

        public Task<IEnumerable<RepairRequest>> GetByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }
    }
}
