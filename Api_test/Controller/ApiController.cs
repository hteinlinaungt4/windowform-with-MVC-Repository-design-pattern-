using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api_test.Model;
using Api_test.Repository;

namespace Api_test.Controller
{
    public class ApiController
    {
        private readonly ApiRepository _apiRepository;

        public ApiController()
        {
            _apiRepository = new ApiRepository();
        }

        public async Task<List<ApiModel>> GetAllObjects()
        {
            try
            {
                return await _apiRepository.GetAllObjects();
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }
        }


        public async Task<ApiModel> CreateApi(ApiModel model)
        {
            try
            {
                return await _apiRepository.CreateApi(model);
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }
        }
    }
}
