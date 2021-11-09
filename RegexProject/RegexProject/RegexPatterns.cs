using System;

using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class RegexPatterns
    {

        public static string FirstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
      


        public bool FirstNameValidate(string FirstName)
        {
            return Regex.IsMatch(FirstName,FirstNamePattern);
        }
    }
}
