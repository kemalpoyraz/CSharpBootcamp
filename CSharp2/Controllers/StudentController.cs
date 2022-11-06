using CSharp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp2.Controllers
{
    [ApiController]
    [Route("api/Students")]

    public class StudentController : Controller
    {
        private readonly BackendContext _context;

        public StudentController()
        {
            _context = new BackendContext();
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudent()
        {
            IQueryable<Student> students = from student in _context.Students
                                           select student;

            return await _context.Students.Include(x => x.GradeId).ToListAsync();
        }
    }
}

