using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentExercise.Students
{
    public class CreateUpdateStudentDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int RollNo { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
