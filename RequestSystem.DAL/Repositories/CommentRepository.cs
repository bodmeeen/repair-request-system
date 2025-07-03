using Microsoft.EntityFrameworkCore;
using RequestSystem.DAL.Data;
using RequestSystem.DAL.Entities;
using RequestSystem.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RequestSystem.DAL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDBContext context) : base(context) { }

        public async Task<IEnumerable<Comment>> GetCommentsByRequestIdAsync(int requestId)
        {
            return await _dbSet.Where(c => c.RepairRequestId == requestId).ToListAsync();
        }
    }
}
