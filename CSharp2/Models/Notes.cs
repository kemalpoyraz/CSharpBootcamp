using System.Collections.Generic;

namespace CSharp2.Models
{
    public record Notes
    {
        public int NotesId { get; set; }
        public int FirstNote { get; set; }
        public int SecondNote { get; set; }

        public double Average => (FirstNote * 0.4) + (SecondNote * 0.6);

        public Student? Student { get; set; }
    }
}

