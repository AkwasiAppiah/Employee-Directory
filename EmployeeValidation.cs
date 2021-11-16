using FluentValidation;

namespace Employee_Directory
{
    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            // First Name
            RuleFor(employee => employee.FirstName).Matches(@"^(?!\s*$).+");

            //Last Name
            RuleFor(employee => employee.LastName).Matches(@"^(?!\s*$).+");
            
            // Department 
            RuleFor(employee => employee.Department).Matches(@"^(?!\s*$).+");

            // Gender
            RuleFor(employee => employee.Gender).Matches(@"^(?!\s*$).+");

            // DOB
            RuleFor(employee => employee.DoB)
                .Matches(@"^(?:0[1-9]|[12]\d|3[01])([\/.-])(?:0[1-9]|1[012])\1(?:19|20)\d\d$");

            // Address 1
            RuleFor(employee => employee.Address1).Matches(@"^(?!\s*$).+");
            // Address 2
            RuleFor(employee => employee.Address2).Matches(@"^(?!\s*$).+");
            // ... 
            RuleFor(employee => employee.Address3).Matches(@"^(?!\s*$).+");

            RuleFor(employee => employee.Address4).Matches(@"^(?!\s*$).+");

            //Postcode
            RuleFor(employee => employee.Postcode)
                .Matches(
                    @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$");

            //Mobile Number
            RuleFor(employee => employee.MoblieNumber).Matches(@"^(07\d{8,12}|447\d{7,11})$");
        }
    }
}
