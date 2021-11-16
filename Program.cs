using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;


namespace Employee_Directory
{
    internal class Program
    {
        // Notes 
        //1.  fluent validation - nuget package - In Progress 

        //2. Case insensitive - throw errors - DONE

        private static void Main()
        {
            var employees = new List<Employee>();
            Console.WriteLine("Welcome to the Employee Database");
            Thread.Sleep(1500);

            var userInput = CollectUserInput.MakeChoice() ?? "";

            do
            {
                switch (userInput.ToLower())
                {
                    case "c":
                        var listOfInputs = CollectUserInput.GetUserInputs().ToList();

                        var employeeToAdd = new Employee()
                        {
                            FirstName = listOfInputs.ElementAt(0),
                            LastName = listOfInputs.ElementAt(1),
                            Department = listOfInputs.ElementAt(2),
                            Gender = listOfInputs.ElementAt(3),
                            DoB = listOfInputs.ElementAt(4),
                            Address1 = listOfInputs.ElementAt(5),
                            Address2 = listOfInputs.ElementAt(6),
                            Address3 = listOfInputs.ElementAt(7),
                            Address4 = listOfInputs.ElementAt(8),
                            Postcode = listOfInputs.ElementAt(9),
                            MoblieNumber = listOfInputs.ElementAt(10),
                            Designation = listOfInputs.ElementAt(11)
                        };

                        var result = new EmployeeValidation().Validate(employeeToAdd);

                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                                // design function to take in result object loop through each failure name and within the class enforce validation returning a dictionary of values to reassign in scope.
                            }
                        }
                        else
                        {
                            employees.Add(employeeToAdd);
                        }

                        userInput = CollectUserInput.MakeChoice();
                        break;

                    case "l":
                        if (!employees.Any())
                        {
                            Console.WriteLine("Directory is empty ");
                        }
                        else
                        {
                            foreach (var employeeToString in employees.Select(employee => JsonConvert.SerializeObject(employee)))
                            {
                                Console.WriteLine(employeeToString);
                            }
                        }

                        userInput = CollectUserInput.MakeChoice() ?? "";
                        break;

                    case "x":
                        break;

                    default:
                        Console.WriteLine("Please enter a valid input");
                        userInput = Console.ReadLine() ?? "";
                        break;
                }

            } while (userInput.ToLower() != "x");

            Console.WriteLine("Thanks for using this program ... Goodbye");
            Console.Read();
        }
    }
}
