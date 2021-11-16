using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Employee_Directory
{
    public static class CollectUserInput
    {
        public static IEnumerable<string> GetUserInputs()
        {
            Console.WriteLine("Welcome to the Employee Database");

            Console.WriteLine("Please enter First Name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter Last Name");
            var lastName = Console.ReadLine();

            Console.WriteLine("Department");
            var department = Console.ReadLine();

            Console.WriteLine("Please enter Gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Please enter DoB in this format dd/mm/yyyy");
            var doB = Console.ReadLine();

            Console.WriteLine("Please enter the first Line of your address");
            var addressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter the second Line of your address");
            var addressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter the third Line of your address");
            var addressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter the fourth Line of your address");
            var addressLine4 = Console.ReadLine();

            Console.WriteLine("Please enter your Postcode in capital letters");
            var postcode = Console.ReadLine();

            Console.WriteLine("Please enter your mobile number");
            var mobileNumber = Console.ReadLine();

            Console.WriteLine("Please enter the designation");
            var designation = Console.ReadLine();

            var userInputArray = new List<string>{firstName,lastName,department,gender,doB,addressLine1,addressLine2,addressLine3,addressLine4,postcode,mobileNumber,designation};

            return userInputArray;
        }

        public static string MakeChoice()
        {
            Console.WriteLine("What do you want to do? Press 'l' to print a list of employees or 'c' to enter one. Press 'x' to exit the program.");
            var userInput = Console.ReadLine();
            return userInput;
        }
    }
}
