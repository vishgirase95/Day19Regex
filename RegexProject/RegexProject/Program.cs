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


        }
    }
}
