using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models.ViewModels;

namespace Web.Interfaces
{
    public interface IStatusRequestHelper
    {
        Task<List<DropDownListModel>> GetRequest();
    }
}
