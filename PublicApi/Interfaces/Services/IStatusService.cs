using PublicApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Interfaces.Services
{
    public interface IStatusService
    {
        Task<List<EmployeeStatus>> GetStatus();
    }
}
