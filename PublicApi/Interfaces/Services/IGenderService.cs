using PublicApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Interfaces.Services
{
    public interface IGenderService
    {
        Task<List<EmployeeGender>> GetGender();
    }
}
