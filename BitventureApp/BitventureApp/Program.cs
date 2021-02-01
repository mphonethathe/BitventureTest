using BitventureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BitventureApp.Service.swapi;
using BitventureApp.util;

namespace BitventureApp
{
    class Program
    {

        static async Task<int> Main(string[] args)
        {
           GetPerson();
           GetFilm();
           GetTranslation();

           return 0;
        }

        public static async void GetPerson()
        {
            HttpClient _httpClient = new HttpClient();
            SwapiService SwapiService = new SwapiService(_httpClient);
            People People = new People();
            Evaluate evaluate = new Evaluate();

            //Call the service to Get Person 
            People = await SwapiService.GetPeople();

            //check if the name is "Luke Skywalker"
            var validateName = evaluate.EvaluateName(People.Name, "Luke Skywalker");

            if (validateName)
            {
                Console.WriteLine($"the name return match Luke Skywalker");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the name return does not match Luke Skywalker");
                Console.ReadLine();
            }




        }

        public static async void GetFilm()
        {
            HttpClient _httpClient = new HttpClient();
            SwapiService SwapiService = new SwapiService(_httpClient);
            Film Film = new Film();
            Evaluate evaluate = new Evaluate();

            //Call the service to Get Film Titile 
            Film = await SwapiService.GetFilm();

            //check if the film title is "A New Hope"
            var validateName = evaluate.EvaluateName(Film.Title, "Luke Skywalker");

            if (validateName)
            {
                Console.WriteLine($"the film title return match A New Hope");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the film title return does not match A New Hope");
                Console.ReadLine();
            }
        }

        public static async void GetTranslation()
        {
            HttpClient _httpClient = new HttpClient();
            SwapiService SwapiService = new SwapiService(_httpClient);
            Film film = new Film();
            Evaluate evaluate = new Evaluate();

            //Call the service to Get Film Titile 
            film = await SwapiService.GetFilm();

            //check if the film title is "A New Hope"
            var validateName = evaluate.EvaluateName(film.Title, "Luke Skywalker");

            if (validateName)
            {
                Console.WriteLine($"the film title return match A New Hope");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the film title return does not match A New Hope");
                Console.ReadLine();
            }
        }

    }
}
