using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Facade;

namespace Infra
{
    public static class Employees
    {
        public static List<Employee> Get()
        {
            var emloyees = new List<Employee>
            {
                new Employee("John", "Doe", 14000),
                new Employee("Michael", "Jackson", 16000),
                new Employee("Roberto", "Pattinson", 20000)
            };
            return emloyees;
        }
    }
}
