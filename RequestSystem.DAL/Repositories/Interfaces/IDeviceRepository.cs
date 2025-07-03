using RequestSystem.DAL.Entities;

namespace RequestSystem.DAL.Repositories.Interfaces
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Task<IEnumerable<Device>> GetDevicesByUserIdAsync(int userId);
    }
}
