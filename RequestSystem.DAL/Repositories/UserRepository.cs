using Microsoft.EntityFrameworkCore;
using RequestSystem.DAL.Data;
using RequestSystem.DAL.Entities;
using RequestSystem.DAL.Repositories.Interfaces;
using System.Threading.Tasks;

namespace RequestSystem.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDBContext context) : base(context) { }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
