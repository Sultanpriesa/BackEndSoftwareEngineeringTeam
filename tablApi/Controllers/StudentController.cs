using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tablApi.Data;
using tablApi.Model;

namespace tablApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students
                .Include(s => s.User)
                .Include(s => s.EnrolledClasses)
                    .ThenInclude(c => c.Tutor)
                .Include(s => s.ClassEntries)
                .ToListAsync();
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students
                .Include(s => s.User)
                .Include(s => s.EnrolledClasses)
                    .ThenInclude(c => c.Tutor)
                .Include(s => s.ClassEntries)
                .FirstOrDefaultAsync(s => s.Student_ID == id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // GET: api/Student/5/Classes
        [HttpGet("{id}/Classes")]
        public async Task<ActionResult<IEnumerable<Class>>> GetStudentClasses(int id)
        {
            var student = await _context.Students
                .Include(s => s.EnrolledClasses)
                    .ThenInclude(c => c.Tutor)
                .FirstOrDefaultAsync(s => s.Student_ID == id);

            if (student == null)
            {
                return NotFound();
            }

            return student.EnrolledClasses.ToList();
        }

        // GET: api/Student/5/ClassEntries
        [HttpGet("{id}/ClassEntries")]
        public async Task<ActionResult<IEnumerable<ClassEntry>>> GetStudentClassEntries(int id)
        {
            var student = await _context.Students
                .Include(s => s.ClassEntries)
                .FirstOrDefaultAsync(s => s.Student_ID == id);

            if (student == null)
            {
                return NotFound();
            }

            return student.ClassEntries.ToList();
        }

        // PUT: api/Student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Student_ID)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.Student_ID }, student);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Student_ID == id);
        }
    }
}
