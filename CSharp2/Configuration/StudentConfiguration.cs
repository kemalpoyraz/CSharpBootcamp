using CSharp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharp2.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
        }
    }
}

