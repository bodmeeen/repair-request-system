using RequestSystem.DAL.Entities;  
using System.Threading.Tasks;

namespace RequestSystem.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}
