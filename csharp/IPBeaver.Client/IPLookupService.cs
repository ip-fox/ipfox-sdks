using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IPFox.Client
{
    public class IPLookupService:IIPLookupService
    {
        private readonly HttpClient _httpClient;
        private readonly ServiceSetting _setting;
        public IPLookupService(HttpClient httpClient, ServiceSetting setting) 
        {
            _httpClient = httpClient;
            _setting = setting;
        }

        public async Task<Location> GetLocationAsync(string ip)
        {
            var msg = await _httpClient.GetAsync($"{_setting.ServiceUrl}/search/{ip}");
            var responseBody=await msg.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Location>(responseBody);
        }
    }
}
