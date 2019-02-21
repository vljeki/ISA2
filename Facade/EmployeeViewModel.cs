using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Facade
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(Employee emp, string userName)
        {
            
        }
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; private set; } = "red";
        public string UserName { get; set; }

        internal void setName(Employee e)
        {
            EmployeeName = e.FirstName + " " + e.LastName;
        }
        internal void setColor(Employee e)
        {
            if (!ReferenceEquals(null, e))
                SalaryColor = e.Salary > 15000 ?
                    "yellow" : "green";
            else SalaryColor = "red";
        }
        internal void setSalary(Employee e)
        {
            Salary = e.Salary.ToString("C");
        }
        internal void setUserName(string userName)
        {
            UserName = userName ?? string.Empty;
            ;
        }
    }
}
