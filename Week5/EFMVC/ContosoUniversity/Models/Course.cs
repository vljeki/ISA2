﻿using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
    
        public int CourseID { get; set; }

  
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
