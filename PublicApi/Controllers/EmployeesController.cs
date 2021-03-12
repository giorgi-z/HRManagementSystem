using Microsoft.AspNetCore.Mvc;
using PublicApi.Entities;
using PublicApi.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Controllers
{
    public class EmployeesController : ApiControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployees(string name)
        {
            return await _service.GetAll(name);
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            await _service.AddEmployee(employee);

            return Ok(new { message = "Employee is added successfully."});
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Employee employee, int id)
        {
            employee.Id = id;

            await _service.UpdateEmployee(employee);

            return Ok(new { message = "Employee is updated successfully."});
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _service.DeleteEmployee(id);

            return Ok(new { message = "Employee is deleted successfully." });
        }
    }
}