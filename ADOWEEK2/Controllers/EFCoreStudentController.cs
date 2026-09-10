using ADOWEEK2.Data;
using Microsoft.AspNetCore.Mvc;
using ADOWEEK2.Models;
using Microsoft.EntityFrameworkCore;

namespace ADOWEEK2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EFCoreStudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EFCoreStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }
        [HttpPost]
        public async Task<IActionResult> AddStudents(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return Ok(student);
        }

    }
}
