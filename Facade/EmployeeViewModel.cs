﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Facade
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(Employee emp)
        {
            if (emp is null) return;
            setName(emp);
            setSalary(emp);
            setColor(emp);
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Salary { get; set; } = 0.ToString("C");
        public string SalaryColor { get; private set; } = "red";
     
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
    }
}
