using Microsoft.AspNetCore.Mvc;
using PublicApi.Entities;
using PublicApi.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Controllers
{
    public class StatusController : ApiControllerBase
    {
        private readonly IStatusService _service;

        public StatusController(IStatusService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<EmployeeStatus>> GetGender()
        {
            var genders = await _service.GetStatus();

            return genders;
        }
    }
}
