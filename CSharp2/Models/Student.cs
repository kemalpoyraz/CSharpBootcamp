using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharp2.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? StudentName { get; set; }
        public DateTime? DateTimeOfBirth { get; set; }
        public decimal StudentHeight { get; set; }
        public float StudentWeight { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }

        public List<Notes>? Notes { get; set; }
    }
}

