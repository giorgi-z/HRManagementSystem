using Microsoft.AspNetCore.Mvc;
using PublicApi.Entities;
using PublicApi.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Controllers
{
    public class GenderController : ApiControllerBase
    {
        private readonly IGenderService _service;

        public GenderController(IGenderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<EmployeeGender>> GetGender()
        {
            var genders = await _service.GetGender();

            return genders;
        }
    }
}
