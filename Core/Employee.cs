using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class Employee
    {
        private const string requiredField = "Required field";
        private const string lenghtIsToBig = "Length should be less than 20 characters!!";

        public Employee()
        {
        }
        public Employee(string firstName,
            string lastName = null, int salary = 0)
        {
            FirstName = firstName?? string.Empty;
            LastName = lastName?? string.Empty;
            Salary = salary;
        }
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = requiredField)]
        [StringLength(20, ErrorMessage = lenghtIsToBig)]
        public string FirstName { get; set; }
        [StringLength(20, ErrorMessage = lenghtIsToBig)]
        public string LastName { get; set; }
        public int Salary { get; set; }

        
    }
}
