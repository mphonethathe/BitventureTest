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
        public bool EvaluateName(string sInput,string sRegex)
        {
            var match = Regex.Match(sInput, $"^{sRegex}");

            return match.Success;

        }
        public bool EvaluateHeight(string height)
        {

            string pattern = @"(\d)";

            var match = Regex.Match(height, pattern);

            return match.Success;

        }


    }
}
