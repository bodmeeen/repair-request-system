using RequestSystem.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RequestSystem.DAL.Repositories.Interfaces
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByRequestIdAsync(int requestId);
    }
}
