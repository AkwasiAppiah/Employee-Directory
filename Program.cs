using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace Employee_Directory
{
    class Program
    {
        // Notes 
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
                        var firstName = Console.ReadLine();

                        Console.WriteLine("Please enter Last Name");
                        var lastName = Console.ReadLine();

                        Console.WriteLine("Department");
                        var department = Console.ReadLine();

                        Console.WriteLine("Please enter Gender");
                        var gender = Console.ReadLine();

                        Console.WriteLine("Please enter DoB");
                        var DoB = Console.ReadLine();

                        Console.WriteLine("Please enter the first Line of your address");
                        var addressLine1 = Console.ReadLine();

                        Console.WriteLine("Please enter the second Line of your address");
                        var addressLine2 = Console.ReadLine();

                        Console.WriteLine("Please enter the third Line of your address");
                        var addressLine3 = Console.ReadLine();

                        Console.WriteLine("Please enter the fourth Line of your address");
                        var addressLine4 = Console.ReadLine();

                        Console.WriteLine("Please enter your Postcode");
                        var postcode = Console.ReadLine();

                        Console.WriteLine("Please enter your mobile number");
                        var mobileNumber = Console.ReadLine();

                        Console.WriteLine("Please enter the designation");
                        var designation = Console.ReadLine();

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

                        var validation = new EmployeeValidation();

                        var result = validation.Validate(employeeToAdd);

                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                            }
                        }

                        //Validate here and give error and only add field that are invalid - regex

                        employees.Add(employeeToAdd);

                        Console.WriteLine("What do you want to do? Press 'l' to print a list of employees or 'c' to enter one. Press 'x' to exit the program.");
                        userInput = Console.ReadLine();
                        break;
                    case "l":
                        // if empty handle this case
                        foreach (var employeeToString in employees.Select(employee => JsonConvert.SerializeObject(employee)))
                        {
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
