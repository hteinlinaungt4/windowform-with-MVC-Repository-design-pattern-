using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Api_test.Contract;
using Api_test.Model;
using Newtonsoft.Json;

namespace Api_test.Repository
{
    public class ApiRepository : ApiContract
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiRepository()
        {
            _httpClient = new HttpClient();
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"];
        }


        public async Task<List<ApiModel>> GetAllObjects()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/objects");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ApiModel>>(json);
        }

        public async Task<ApiModel> CreateApi(ApiModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response  = await _httpClient.PostAsync($"{_baseUrl}/objects", content);
            response.EnsureSuccessStatusCode();
            var resultJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiModel>(resultJson);
        }
    }
}
