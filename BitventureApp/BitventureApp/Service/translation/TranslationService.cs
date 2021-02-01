using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using BitventureApp.Models;

namespace BitventureApp.Service.translation
{
    class TranslationService
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public TranslationService(
            HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Transalation> GetTranslation()
        {
            var response = await _httpClient.GetAsync("https://api.funtranslations.com/translate/groot.json?text=Rocket%20hold%20still.");

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<Transalation>(responseStream, jsonSerializerOptions);
            }
            else
            {

            }

            return null;
        }


    }
}