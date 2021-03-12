using Flurl.Http;
using Flurl.Http.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models.ViewModels;

namespace Web.Services
{
    public class EmployeeRequestHelper : IEmployeeRequestHelper
    {
        private readonly IFlurlClient _flurl;
        private readonly string _baseUrl ="https://localhost:44346/api";

        public EmployeeRequestHelper(IFlurlClientFactory flurl)
        {
            _flurl = flurl.Get(_baseUrl);
        }

        public async Task<List<EmployeeViewModel>> GetRequest(string name = null)
        {
            return await _flurl.Request($"employees?name={name}").GetJsonAsync<List<EmployeeViewModel>>();
        }

        public async Task<EmployeeViewModel> GetByIdRequest(int id)
        {
            return await _flurl.Request($"employees/{id}").GetJsonAsync<EmployeeViewModel>();
        }

        public async Task<string> PostRequest(EmployeeViewModel employee)
        {
            return await _flurl.Request("employees").PostJsonAsync(employee).ReceiveString();
        }

        public async Task PutRequest(int id, EmployeeViewModel employee)
        {
            await _flurl.Request($"employees/{id}").PutJsonAsync(employee);
        }

        public async Task DeleteRequest(int id)
        {
            await _flurl.Request($"employees/{id}").DeleteAsync();
        }
    }
}
