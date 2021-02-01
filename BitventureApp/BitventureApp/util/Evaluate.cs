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
            if (sInput != null && sRegex != null)
            {
                var match = Regex.Match(sInput, $"^{sRegex}");
                return match.Success;
            }

            return false;
            

        }
        public bool EvaluateHeight(string height)
        {
            if (height != null)
            {
                string pattern = @"(\d)";

                var match = Regex.Match(height, pattern);

                return match.Success;
            }

            return false;

        }

        public bool EvaluateEmail(string email)
        {
            if (email != null)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,20})+)$");
                Match match = regex.Match(email);

                return match.Success;
            }
            return false;

        }


    }
}
