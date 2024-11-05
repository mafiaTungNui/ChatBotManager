using ChatBotManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotManager.Services
{
    public class ApiService
    {
        private readonly HttpClient client;

        public ApiService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/"); // Địa chỉ API server của bạn
        }

        // Phương thức lấy danh sách intents từ API
        public async Task<List<Intent>> GetIntentsAsync()
        {
            var response = await client.GetAsync("api/intents");
            response.EnsureSuccessStatusCode(); // Kiểm tra nếu yêu cầu thành công

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Intent>>(json);
        }

        // Phương thức lấy danh sách responses theo intent ID từ API
        public async Task<List<Response>> GetResponsesByIntentAsync(string intentId)
        {
            var response = await client.GetAsync($"api/responses/byintent/{intentId}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Response>>(json);
        }
        public async Task<bool> AddIntentAsync(string intentName)
        {
            var newIntent = new { IntentName = intentName }; // Chỉ gửi IntentName
            var json = JsonConvert.SerializeObject(newIntent);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("api/intents", content);
            return response.IsSuccessStatusCode;
        }
    }
}
