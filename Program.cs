using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace Employee_Directory
{
    class Program
    {
        // Notes 
            // I believe I could have used the builder class here to build the employee object a bit more succinctly but wanted to keep it simple!
            // Also I haven't added any validation to keep it simple! 
            //1.  fluent validation - nuget package

            //2. Case insensitive - throw errors 

        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            // read up!
            Console.WriteLine("Welcome to the Employee Database");
            Thread.Sleep(2000);
            Console.WriteLine("What do you want to do? Press 'l' to print a list of employees or 'c' to enter one. Press 'x' to exit the program.");

            var userInput = Console.ReadLine();

            do
            {
                switch (userInput)
                {
                    // abstract this out
                    case "c":
                        Console.WriteLine("Welcome to the Employee Database");

                        Console.WriteLine("Please enter First Name");
                        string firstName = Console.ReadLine();

                        Console.WriteLine("Please enter Last Name");
                        string lastName = Console.ReadLine();

                        Console.WriteLine("Department");
                        string department = Console.ReadLine();

                        Console.WriteLine("Please enter Gender");
                        string gender = Console.ReadLine();

                        Console.WriteLine("Please enter DoB");
                        string DoB = Console.ReadLine();

                        Console.WriteLine("Please enter the first Line of your address");
                        string addressLine1 = Console.ReadLine();

                        Console.WriteLine("Please enter the second Line of your address");
                        string addressLine2 = Console.ReadLine();

                        Console.WriteLine("Please enter the third Line of your address");
                        string addressLine3 = Console.ReadLine();

                        Console.WriteLine("Please enter the fourth Line of your address");
                        string addressLine4 = Console.ReadLine();

                        Console.WriteLine("Please enter your Postcode");
                        string postcode = Console.ReadLine();

                        Console.WriteLine("Please enter your mobile number");
                        string mobileNumber = Console.ReadLine();

                        Console.WriteLine("Please enter the designation");
                        string designation = Console.ReadLine();

                        Employee employeeToAdd = new Employee()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Department = department,
                            Gender = gender,
                            DoB = DoB,
                            Address1 = addressLine1,
                            Address2 = addressLine2,
                            Address3 = addressLine3,
                            Address4 = addressLine4,
                            Postcode = postcode,
                            MoblieNumber = mobileNumber,
                            Designation = designation
                        };

                        //Validate here and give error and only add field that are invalid - regex
                        
                        employees.Add(employeeToAdd);

                        Console.WriteLine("What do you want to do? Press 'l' to print a list of employees or 'c' to enter one. Press 'x' to exit the program.");
                        userInput = Console.ReadLine();
                        break;
                    case "l":
                        // if empty handle this case
                        foreach (var employee in employees)
                        {
                            string employeeToString = JsonConvert.SerializeObject(employee);
                            Console.WriteLine(employeeToString);
                        }
                        Console.WriteLine("What do you want to do? Press 'l' to print a list of employees or 'c' to enter one. Press 'x' to exit the program.");
                        userInput = Console.ReadLine();
                        break;
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        userInput = Console.ReadLine();
                        break;
                }

            } while (userInput != "x");

            Console.WriteLine("Thanks for using this program ... Goodbye");
            Console.Read();
        }
    }
}
