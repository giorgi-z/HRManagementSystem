using PublicApi.Entities;
using PublicApi.Interfaces.Repositories;
using PublicApi.Interfaces.Services;
using PublicApi.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryBase<Employee> _employeesRepo;

        public EmployeeService(IRepositoryBase<Employee> employeesRepo)
        {
            _employeesRepo = employeesRepo;
        }

        public async Task<List<Employee>> GetAll(string name)
        {
            var spec = new EmployeeWithGenderAndStatusSpecification(name);

            return await _employeesRepo.ListAsync(spec);
        }

        public async Task<Employee> GetById(int id)
        {
            return await _employeesRepo.GetByIdAsync(id);
        }

        public async Task AddEmployee(Employee employee)
        {
            await _employeesRepo.AddAsync(employee);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _employeesRepo.UpdateAsync(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _employeesRepo.DeleteAsync(id);
        }
    }
}
