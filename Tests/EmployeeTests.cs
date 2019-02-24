﻿using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FirstNameTest()
        {
            Employee e = new Employee("eesnimi", null, 0);
            Assert.AreEqual("eesnimi", e.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            Employee e = new Employee(null, "perenimi", 0);
            Assert.AreEqual("perenimi", e.LastName);
        }

        [TestMethod]
        public void SalaryTest()
        {
            Employee e = new Employee(null, null, 100);
            Assert.AreEqual(100, e.Salary);
        }
    }
}
