using System;
using System.Collections.Generic;

namespace ContosoUniTTHK.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
