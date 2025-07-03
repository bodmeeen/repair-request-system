using Microsoft.EntityFrameworkCore;
using RequestSystem.DAL.Entities;
using RequestSystem.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RequestSystem.DAL.Repositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(RequestSystemDbContext context) : base(context) { }

        public async Task<IEnumerable<Device>> GetDevicesByUserIdAsync(int userId)
        {
            return await _dbSet.Where(d => d.UserId == userId).ToListAsync();
        }
    }
}
