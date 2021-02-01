using BitventureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BitventureApp.Service.swapi;
using BitventureApp.Service.translation;
using BitventureApp.util;

namespace BitventureApp
{
    class Program
    {

        static async Task<int> Main(string[] args)
        {


            HttpClient _httpClient = new HttpClient();
            SwapiService SwapiService = new SwapiService(_httpClient);
            TranslationService TranslationService = new TranslationService(_httpClient);
            Validation validation = new Validation();
            People People;
            Film Film;
            Transalation Transalation;


            //Call the service to Get Person 
            People = await SwapiService.GetPeople();

            //Call the service to Get Film 
            Film = await SwapiService.GetFilm();

            //Call the service to Get translation
            Transalation = await TranslationService.GetTranslation();

          


            if (People != null)
            {
                //validate Person details
              Console.WriteLine(validation.ValidatePerson(People));

            }
            else
            {
                Console.WriteLine("Something went wrong while calling the service");
            }

            if(Film!= null)
            {
                Console.WriteLine(validation.ValidateFilm(Film));
  
            }
            else
            {
                Console.WriteLine("Something went wrong while calling the service");
            }

            if (Transalation != null)
            {
                Console.WriteLine(validation.ValidateTranslation(Transalation));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Something went wrong while calling the service");
            }




            return 0;
        }




    }
}
