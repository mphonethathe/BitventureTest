using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BitventureApp.Service.geoplugin
{
    public class GeopliginService
    {

        private readonly HttpClient _httpClient;

        public GeopliginService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetGeoplugin()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://www.geoplugin.net/xml.gp?ip=105.184.92.37");
                if (response.IsSuccessStatusCode)
                {
                   return await response.Content.ReadAsStringAsync();
                   
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} -GetPeople() ");

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} - GetGeoplugin() ");

            }

            return null;
        }

    }
}
