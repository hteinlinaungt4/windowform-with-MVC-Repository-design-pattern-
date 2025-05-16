
using System.Collections.Generic;

using System.Threading.Tasks;
using Api_test.Model;

namespace Api_test.Contract
{
    public interface ApiContract
    {

        Task<List<ApiModel>> GetAllObjects();

        Task<ApiModel> CreateApi(ApiModel model);
    }
}
