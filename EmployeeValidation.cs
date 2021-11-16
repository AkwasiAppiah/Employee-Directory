using FluentValidation;

namespace Employee_Directory
{
    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            // First Name
            //Regex for not null
            RuleFor(employee => employee.FirstName).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank");

            //Last Name
            RuleFor(employee => employee.LastName).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank"); ;
            
            // Department 
            RuleFor(employee => employee.Department).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank"); ;

            // Gender
            RuleFor(employee => employee.Gender).Matches(@"^(?:m|M|male|Male|f|F|female|Female)$");

            // DOB
            RuleFor(employee => employee.DoB).Matches(@"^(?:0[1-9]|[12]\d|3[01])([\/.-])(?:0[1-9]|1[012])\1(?:19|20)\d\d$").WithMessage("dd/mm/yyyy");

            // Address 1
            RuleFor(employee => employee.Address1).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank"); ;
            // Address 2
            RuleFor(employee => employee.Address2).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank"); ;
            // ... 
            RuleFor(employee => employee.Address3).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank"); ;

            RuleFor(employee => employee.Address4).Matches(@"^(?!\s*$).+").WithMessage("Please do not leave blank"); ;

            //Postcode
            RuleFor(employee => employee.Postcode).Matches(@"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$").WithMessage("Please enter a valid Postcode");

            //Mobile Number
            RuleFor(employee => employee.MoblieNumber).Matches(@"^(07\d{8,12}|447\d{7,11})$").WithMessage("Please enter a valid mobile number");
        }
    }
}
