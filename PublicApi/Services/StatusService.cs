using PublicApi.Entities;
using PublicApi.Interfaces.Repositories;
using PublicApi.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Services
{
    public class StatusService : IStatusService
    {
        private readonly IRepositoryBase<EmployeeStatus> _statusRepo;

        public StatusService(IRepositoryBase<EmployeeStatus> statusRepo)
        {
            _statusRepo = statusRepo;
        }

        public async Task<List<EmployeeStatus>> GetStatus()
        {
            return await _statusRepo.ListAllAsync();
        }
    }
}
