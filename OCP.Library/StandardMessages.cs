using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Library
{
    public class StandardMessages
    {
        public static void EmployeeOutputMessage(EmployeeModel employee)
        {
            Console.WriteLine($"{ employee.FirstName } { employee.LastName } | { employee.DOB.ToString("d")} | { employee.EmployeeID }, { employee.Email }, {employee.Salary.salary:C3}");
        }
    }
}
