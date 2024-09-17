using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace FrontEnd.Carrefour.Service
{
    public class CarrefourApiService 
    {   
        private readonly string baseUrlApi = string.Empty;

        public CarrefourApiService(IConfiguration configuration)
        {
            this.baseUrlApi = configuration["Services:Carrefour.api"];
        }

        public async Task<T> RequestGet<T> (string restResource) 
        {
            string fullRestResource = this.baseUrlApi + restResource;
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(fullRestResource);

            string jsonResponse = await result.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<T>(jsonResponse);

            return model;
        }

        public async Task<string> RequestPost(string restResource, object model) 
        {
            string fullRestResource = this.baseUrlApi + restResource;
            HttpClient client = new HttpClient();

            var httpContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var result = await client.PostAsync(fullRestResource, httpContent);

            string jsonResponse = await result.Content.ReadAsStringAsync();

            return jsonResponse;
        }

        
        public async Task<string> RequestDelete(string restResource) 
        {
            string fullRestResource = this.baseUrlApi + restResource;
            HttpClient client = new HttpClient();

            var result = await client.DeleteAsync(fullRestResource);

            string jsonResponse = await result.Content.ReadAsStringAsync();

            return jsonResponse;
        }
    }
}