using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Facade;

namespace Infra
{
    public static class Employees
    {
        public static List<Employee> Get(SalesDbContext db)
        {
            return db.Employees.ToList();
        }

        public static object Get()
        {
            throw new NotImplementedException();
        }
    }
}
