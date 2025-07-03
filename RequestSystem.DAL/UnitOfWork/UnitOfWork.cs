using System.Threading.Tasks;
using RequestSystem.DAL.Data;
using RequestSystem.DAL.Repositories;
using RequestSystem.DAL.Repositories.Interfaces;

namespace RequestSystem.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public IUserRepository Users { get; }
        public IDeviceRepository Devices { get; }
        public IRepairRequestRepository RepairRequests { get; }
        public ICommentRepository Comments { get; }

        public UnitOfWork(ApplicationDBContext context,
                          IUserRepository userRepository,
                          IDeviceRepository deviceRepository,
                          IRepairRequestRepository repairRequestRepository,
                          ICommentRepository commentRepository)
        {
            _context = context;
            Users = userRepository;
            Devices = deviceRepository;
            RepairRequests = repairRequestRepository;
            Comments = commentRepository;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
