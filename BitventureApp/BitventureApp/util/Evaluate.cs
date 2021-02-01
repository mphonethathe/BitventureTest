using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BitventureApp.util
{
    public class Evaluate
    {
        public bool EvaluateName(string name,string sRegex)
        {
            var match = Regex.Match(name, $"^{sRegex}");
             
            bool results = (match.Success) ? true : false;

            return results;

        }
        public bool EvaluateHeight(int height)
        {
            //var match = Regex.Matches(height, $"//d");

            //bool results = (match.) ? true : false;

            //return results;

            return true;

        }


    }
}
