using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Library
{
    public class Account
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.DOB = person.DOB;
            output.Email = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@company.com";
            output.EmployeeID = $" { person.FirstName.Substring(0, 1) }{ person.LastName.Substring(0, 3).ToUpperInvariant() }{ RandomNumberGenerator() }";

            return output;
        }

        public Salary NewSalary(EmployeeModel person)
        {
            Salary output = new Salary();

            output.salary = (decimal)Salary.Rate.Base; 

            return output;
        }

        private static string RandomNumberGenerator()
        {
            int output = rnd.Next(1000, 9999);
            return output.ToString();
        }

        private static Random rnd = new Random();
    }
}
