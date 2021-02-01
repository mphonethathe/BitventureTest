using BitventureApp.Models;
using BitventureApp.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitventureApp
{
    public  class Validation
    {
        public string ValidatePerson(People People)
        {
            if (People != null)
            {
                Evaluate evaluate = new Evaluate();

                //check if the name is "Luke Skywalker"
                var validateName = evaluate.EvaluateName(People.Name, "Luke Skywalker");

                //check if the height is digit"
                var validateHeight = evaluate.EvaluateHeight(People.Height);


                var res = (validateName) ? "the name returned match Luke Skywalker" : "the name returned does not match Luke Skywalker";


                var res2 = (validateHeight) ? "the height returned is valid digit" : "the height returned is invalid digit";
                return $"{res}\n{res2}";
            }


            return null;


        }


        public string ValidateFilm(Film film)
        {
            if (film != null)
            {
                Evaluate evaluate = new Evaluate();

                //check if the height is digit"
                var validateTitle = evaluate.EvaluateName(film.Title, "A New Hope");

                //check if the height is digit"
                var validateDirector = evaluate.EvaluateName(film.Director, "Rick McCallum");


                var res = (validateTitle) ? "the title returned match A New Hope" : "the title returned does not match A New Hope";


                var res2 = (validateDirector) ? "the Director returned Rick McCallum" : "the Director returned does not match Rick McCallum";


                return $"{res}\n{res2}";
            }
            return null;

        }



        public string ValidateTranslation(Transalation transalation)
        {
            if (transalation != null)
            {
                Evaluate evaluate = new Evaluate();

                //check if the transalation match groot"
                var validateTitle = evaluate.EvaluateName(transalation.Contents.Translation, "groot");

                var res = (validateTitle) ? "the Translation returned match groot" : "the Translation returned does not match groot";

                return $"{res}";
            }

            return null;
         

        }

    }
}
