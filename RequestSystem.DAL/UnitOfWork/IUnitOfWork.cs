using System;
using System.Threading.Tasks;
using RequestSystem.DAL.Repositories.Interfaces;

namespace RequestSystem.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IDeviceRepository Devices { get; }
        IRepairRequestRepository RepairRequests { get; }
        ICommentRepository Comments { get; }

        Task<int> CommitAsync();
    }
}
