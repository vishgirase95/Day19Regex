using System;

using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class RegexPatterns
    {

        public static string FirstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        public static string LastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        public static string EmailIDPattern = "^[a-z]{3,}[.]*[a-zA-Z0-9]{1,}[@]{1}[a-z]{3,}[.]{1}[a-z]{2,4}$";
        public static string MobilePattern = "^[1-9]{1}[0-9]{1,2}[ ]{1}[7-9]{1}[0-9]{9}$";
        public static string PaswordPattern = "^[a-zA-Z0-9]{8,}$";
        public static string PaswordPatternWithOneCap = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        public static string PaswordPatternWithOneNumeric = "^(?=.*[0-9])[a-zA-Z0-9]{8,}$";









        public bool FirstNameValidate(string FirstName)
        {
            return Regex.IsMatch(FirstName,FirstNamePattern);
        }


        public bool LastNameValidate(string LastName)
        {
            return Regex.IsMatch(LastName, LastNamePattern);
        }

        public bool EmailIdValidate(string Email)
        {
            return Regex.IsMatch(Email, EmailIDPattern);
        }

        public bool PhoneNumberValidate(string Number)
        {
            return Regex.IsMatch(Number, MobilePattern);
        }
        public bool PaswordValidate(string Pasword)
        {
            return Regex.IsMatch(Pasword, PaswordPattern);
        }

        public bool PaswordWithOneCapValidate(string pasword2)
        {
            return Regex.IsMatch(pasword2, PaswordPatternWithOneCap);
        }
        
        public bool PaswordWithOneNUmeric(string pasword3)
        {
            return Regex.IsMatch(pasword3, PaswordPatternWithOneNumeric);
        }
    }


}
