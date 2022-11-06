using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharp2.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [StringLength(100)]
        public string? GradeName { get; set; }
        [StringLength(50)]
        public int Section { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
