﻿using System.ComponentModel.DataAnnotations;

namespace StudentRegistrationDBDEMO
{
    internal class Student
    {
        [Key]
        public int StudentId { get; }

        [Required(ErrorMessage = "First name is required.")]
        public string? StudentFirstName { get; set; }

        public string? StudentLastName { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string? StudentCity { get; set; }
    }
}