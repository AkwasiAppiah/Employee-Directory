using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Text;
using FluentValidation;

namespace Employee_Directory
{
    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            // First Name
            RuleFor(employee => employee.FirstName).NotNull();

            //Last Name
            RuleFor(employee => employee.LastName).NotNull();
            
            // Department 
            RuleFor(employee => employee.Department).NotNull();

            // Gender
            RuleFor(employee => employee.Gender).NotNull();

            // DOB
            RuleFor(employee => employee.DoB)
                .Matches(@"^(?:0[1-9]|[12]\d|3[01])([\/.-])(?:0[1-9]|1[012])\1(?:19|20)\d\d$");

            // Address 1
            // Address 2
            // ... 

            //Postcode

            //Mobile Number
            RuleFor(employee => employee.MoblieNumber).Matches(@"^(07\d{8,12}|447\d{7,11})$");
        }
    }
}
