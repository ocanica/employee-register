using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRegister.Library;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Chris", LastName = "Kingsley", DOB = new DateTime(1994, 1, 9) },
                new PersonModel { FirstName = "Jemma", LastName = "Markey", DOB = new DateTime(1978, 5, 19) },
                new PersonModel { FirstName = "Gareth", LastName = "McKenzie", DOB = new DateTime(1987, 12, 29) }
            };

            Account employeeProcessor = new Account();
            Salary salary = new Salary();

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (PersonModel person in applicants)
            {
                employees.Add(employeeProcessor.Create(person));
            }

            foreach (EmployeeModel employee in employees)
            {
                employee.Salary = employeeProcessor.NewSalary(employee);

                if (employee.LastName == "Markey")
                    employee.Salary.SetSalary(Salary.Rate.Director);
                if (employee.LastName == "Kingsley")
                    employee.Salary.SetSalary(Salary.Rate.Developer);
            }

            foreach (EmployeeModel employee in employees)
            {
                StandardMessages.EmployeeOutputMessage(employee);
            }
        }
    }
}
