using PublicApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAll(string name);
        Task<Employee> GetById(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
