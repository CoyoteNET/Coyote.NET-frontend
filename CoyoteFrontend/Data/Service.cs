using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using CoyoteNETCore.Shared.RequestInput;
using System.Text;

namespace CoyoteFrontend.Data
{
    public class Service
    {        
        public async Task<bool> TryRegister(RegisterInput command)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(command);

                var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Post, "http://localhost:5000/Account/Register/")
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                });

                var responseJson = await response.Content.ReadAsStringAsync();
                return true; // JsonConvert.DeserializeObject<bool>(responseJson);
            }
        }
    }
}
