using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.ViewModels;

namespace Web.Interfaces
{
    public interface IGenderRequestHelper
    {
        Task<List<DropDownListModel>> GetRequest();
    }
}
