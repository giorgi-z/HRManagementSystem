using PublicApi.Entities;
using PublicApi.Interfaces.Repositories;
using PublicApi.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Services
{
    public class GenderService : IGenderService
    {
        private readonly IRepositoryBase<EmployeeGender> _genderRepo;

        public GenderService(IRepositoryBase<EmployeeGender> genderRepo)
        {
            _genderRepo = genderRepo;
        }

        public async Task<List<EmployeeGender>> GetGender()
        {
            return await _genderRepo.ListAllAsync();
        }
    }
}
