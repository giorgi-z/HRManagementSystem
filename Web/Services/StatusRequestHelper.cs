using Flurl.Http;
using Flurl.Http.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Interfaces;
using Web.Models.ViewModels;

namespace Web.Services
{
    public class StatusRequestHelper : IStatusRequestHelper
    {
        private readonly IFlurlClient _flurl;
        private readonly string _baseUrl = "https://localhost:44346/api";

        public StatusRequestHelper(IFlurlClientFactory flurl)
        {
            _flurl = flurl.Get(_baseUrl);
        }

        public async Task<List<DropDownListModel>> GetRequest()
        {
            return await _flurl.Request("status").GetJsonAsync<List<DropDownListModel>>();
        }
    }
}
