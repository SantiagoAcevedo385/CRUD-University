using System.ComponentModel.DataAnnotations;
using System;

namespace AppSantiago.Models

{

    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        [Key]

        public int EnrollmentID { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        [Required(ErrorMessage = "The Grade field is required.")]
        public Grade? Grade { get; set; }

        public Student? Student { get; set; }

        public Course? Course { get; set; }
    }
}
