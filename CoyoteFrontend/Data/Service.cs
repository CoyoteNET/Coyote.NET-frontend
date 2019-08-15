using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.Configuration;
using CoyoteNETCore.Shared.ResultHandling;
using System.Net.Http.Headers;

namespace CoyoteFrontend.Data
{
    public class Service
    {
        private readonly IConfiguration _configuration;

        public Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Result<U>> TryPOST<T, U>(T command, string endpoint, string bearer_token = "")
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(command);

                var request = new HttpRequestMessage(HttpMethod.Post, _configuration["Backend:Host"] + endpoint)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };

                if (!string.IsNullOrEmpty(bearer_token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearer_token);
                }

                var response = await client.SendAsync(request);

                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Console.Clear();
                    Console.WriteLine(responseString);
                    Console.WriteLine(typeof(U));
                    var t = JsonConvert.DeserializeObject<U>(responseString);
                    return new Result<U>(t);
                }

                return new Result<U>(ErrorType.BadRequest, responseString);
            }
        }

        public async Task<Result<U>> TryGET<U>(string endpoint, string bearer_token = "")
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, _configuration["Backend:Host"] + endpoint)
                {
                };

                if (!string.IsNullOrEmpty(bearer_token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearer_token);
                }

                var response = await client.SendAsync(request);

                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var t = JsonConvert.DeserializeObject<U>(responseString, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                    return new Result<U>(t);
                }

                return new Result<U>(ErrorType.BadRequest, responseString);
            }
        }
    }
}
