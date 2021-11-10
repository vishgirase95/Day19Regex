using System;


namespace RegexProject
{
    class Program
    {
        static void Main(string[] args)
        {
          
            RegexPatterns obj = new RegexPatterns();
            Console.WriteLine("First name validation : "+obj.FirstNameValidate("Vishal"));

            Console.WriteLine("Last name Validation : " +obj.LastNameValidate("Girase"));
            
            Console.WriteLine("Email Validation : " + obj.EmailIdValidate("vish.girase95@gmail.in"));
             
            Console.WriteLine("Phone Number Validation : " + obj.PhoneNumberValidate("911 8806001896"));
            Console.WriteLine("Pasword Validation : " + obj.PaswordValidate("88060055"));
            Console.WriteLine("Pasword Validation with one Caps : " + obj.PaswordWithOneCapValidate("bbAchgghhgfj45"));
            Console.WriteLine("Pasword Validation with One Numeric : " + obj.PaswordWithOneNUmeric("AAAbAschgghhgfj45"));
            Console.WriteLine("Pasword Validation with One Numeric : " + obj.PaswordWithOneSpecialChar("@A$AAAgyt@@&!$$%^bschgghhgfj45"));







        }
    }
}


