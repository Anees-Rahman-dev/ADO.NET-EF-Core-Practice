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
            var students = await _context.Students.ToListAsync(); // It executes a database query and puts the results into a List<T> asynchronously
            return Ok(students);
        }
        [HttpPost]
        public async Task<IActionResult> AddStudents(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();//Asynchronously saves all changes made in this context to the underlying database.

            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            var IsStudentExist = await _context.Students.FindAsync(id);// used to find an entity by its primary key value

            if (IsStudentExist == null)
            {
                return NotFound();
            }
            else
            {
                IsStudentExist.name = student.name;
                IsStudentExist.Age = student.Age;
            }

            await _context.SaveChangesAsync();
            return Ok(IsStudentExist);

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteStudent(int id)
        {
            var IsStudentEXist = await _context.Students.FindAsync(id);

            if (IsStudentEXist == null)
            {
                return NotFound();
            }
            else
            {
                _context.Students.Remove(IsStudentEXist);
            }
            await _context.SaveChangesAsync();

            return Ok("STUDENT HAS DELETED");
        }

    }
}
