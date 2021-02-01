using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using BitventureApp.Models;

namespace BitventureApp.Service.swapi
{
   public class SwapiService
    {
        private readonly HttpClient _httpClient;

        public SwapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };


        public async Task<People> GetPeople()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://swapi.dev/api/people/1");

                if (response.IsSuccessStatusCode)
                {
                    var responseStream = await response.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<People>(responseStream, jsonSerializerOptions);

                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} -GetPeople() ");

                }

              
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} -GetPeople() ");

            }

            return null;
        }


        public async Task<Film> GetFilm()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://swapi.dev/api/films/1");

                if (response.IsSuccessStatusCode)
                {
                    var responseStream = await response.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<Film>(responseStream, jsonSerializerOptions);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} -GetFilm");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} -GetFilm()");

            }


            return null;
        }
    }
}
