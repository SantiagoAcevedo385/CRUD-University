using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace AppSantiago.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }


        public ICollection<Enrollment>? Enrollment { get; set; }
    }
}

