﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
}
