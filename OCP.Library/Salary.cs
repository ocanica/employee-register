using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Library
{
    public class Salary
    {
        public decimal salary;

        public enum Rate
        {
            Base = 0,
            Developer = 35000,
            Manager = 43000,
            Director = 68000
        };

        public void SetSalary(Rate rate)
        {
            this.salary = (decimal)rate;
        }

        public void IncreaseSalary()
        {
            this.salary = this.salary * (decimal)1.1;
        }

        public void DecreaseSalary()
        {
            this.salary = this.salary * (decimal)0.1;
        }

        public decimal GetSalary()
        {
            return this.salary;
        }
    }
}
