using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.ViewModels;

namespace Web
{
    public interface IEmployeeRequestHelper
    {
        Task<List<EmployeeViewModel>> GetRequest(string name = null);
        Task<EmployeeViewModel> GetByIdRequest(int id);
        Task<string> PostRequest(EmployeeViewModel employee);
        Task PutRequest(int id, EmployeeViewModel employee);
        Task DeleteRequest(int id);
    }
}
