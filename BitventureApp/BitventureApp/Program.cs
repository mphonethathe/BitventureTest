using BitventureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BitventureApp.Service.swapi;
using BitventureApp.Service.translation;
using BitventureApp.Service.geoplugin;
using BitventureApp.util;
using BitventureApp.Service;

namespace BitventureApp
{
    class Program
    {

        static async Task<int> Main(string[] args)
        {


            HttpClient _httpClient = new HttpClient();
            SwapiService SwapiService = new SwapiService(_httpClient);
            TranslationService TranslationService = new TranslationService(_httpClient);
            EmailService EmailService = new EmailService();
            GeopliginService GeopliginService = new GeopliginService(_httpClient);
            Evaluate evaluate = new Evaluate(); 
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


            //Call Geopligin service
            var geo = await GeopliginService.GetGeoplugin();
            
            if (People != null)
            {
                //validate Person details
              Console.WriteLine(validation.ValidatePerson(People));

            }
            
            if(Film!= null)
            {
                //validate Film
                Console.WriteLine(validation.ValidateFilm(Film));
  
            }        

            if (Transalation != null)
            {
                //validate Transalation
                Console.WriteLine(validation.ValidateTranslation(Transalation));
             
            }



            //Send results via email

            Console.WriteLine("_____________________________________________________________________");

            Console.WriteLine("Do you want to send this information via Email? Reply with yes of no");

            string Answer = Console.ReadLine();

            if(Answer == "yes")
            {
                Console.WriteLine("Enter Email Address");

                string UserEmail = Console.ReadLine();
                //check if is valid email
                if (evaluate.EvaluateEmail(UserEmail))
                {

                    Email Email = new Email();
                    Email.To = UserEmail;
                    Email.Subject = "BitventureCodeTest";
                    Email.Body = $"{validation.ValidatePerson(People) } \n {validation.ValidateFilm(Film)} \n {validation.ValidateTranslation(Transalation)}";

                    Console.WriteLine(EmailService.SendEmail(Email));
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }



            Console.ReadLine();


            return 0;
        }




    }
}
