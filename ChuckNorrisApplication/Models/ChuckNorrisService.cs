
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Models
{

    public class ChuckNorrisService : IChuckNorrisService
    {
        private HttpClient _httpClient;

        public ChuckNorrisService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ChuckNorris> GetNorris()
        {
            string UrlParameter = "jokes/random";

            var response = await _httpClient.GetAsync(UrlParameter);

            var json = await response.Content.ReadAsStringAsync();

            var chuckNorris = JsonConvert.DeserializeObject<ChuckNorris>(json);

            return chuckNorris;
        }

      
    }
}
