using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tablApi.Data;
using tablApi.Model;
using tablApi.Services;

namespace tablApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ClassEntryGenerator _classEntryGenerator;

        public StudentController(ApplicationDbContext context, ClassEntryGenerator classEntryGenerator)
        {
            _context = context;
            _classEntryGenerator = classEntryGenerator;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students
                .Include(s => s.User)
                .Include(s => s.EnrolledClasses)
                .ToListAsync();
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetStudent(int id)
        {
            var student = await _context.Students
                .Include(s => s.User)
                .Include(s => s.EnrolledClasses!)
                    .ThenInclude(c => c.Tutor)
                        .ThenInclude(t => t.User)
                .FirstOrDefaultAsync(s => s.Student_ID == id);

            if (student == null)
            {
                return NotFound();
            }

            // Get class entries with detailed information
            var classEntries = await _context.ClassEntries
                .Include(ce => ce.Class)
                    .ThenInclude(c => c.Tutor)
                        .ThenInclude(t => t.User)
                .Include(ce => ce.ClassSchedule)
                .Where(ce => ce.Students != null && ce.Students.Any(s => s.Student_ID == id) && !ce.IsDeleted)
                .ToListAsync();

            // Create a detailed response object
            var response = new
            {
                Student_ID = student.Student_ID,
                FirstName = student.Student_firstName,
                LastName = student.Student_LastName,
                YearLevel = student.student_yearLevel,
                User_ID = student.User_ID,
                User = student.User != null ? new
                {
                    student.User.User_ID,
                    student.User.User_email,
                    student.User.User_type
                } : null,
                EnrolledClasses = student.EnrolledClasses?.Select(c => new
                {
                    c.Class_ID,
                    c.Class_Name,
                    c.Class_Desc,
                    c.Class_yearLevel,
                    c.StartDate,
                    c.EndDate,
                    Tutor = c.Tutor != null ? new
                    {
                        c.Tutor.Tutor_ID,
                        c.Tutor.Tutor_firstName,
                        c.Tutor.Tutor_LastName,
                        User = c.Tutor.User != null ? new
                        {
                            c.Tutor.User.User_ID,
                            c.Tutor.User.User_email,
                            c.Tutor.User.User_type
                        } : null
                    } : null,
                    Schedules = c.Schedules?.Select(s => new
                    {
                        s.Schedule_ID,
                        s.DayOfWeek,
                        s.StartTime,
                        s.EndTime,
                        s.Room
                    })
                }),
                ClassEntries = classEntries.Select(ce => new
                {
                    ce.ClassEntry_ID,
                    Class = ce.Class != null ? new
                    {
                        ce.Class.Class_ID,
                        ce.Class.Class_Name,
                        ce.Class.Class_Desc,
                        ce.Class.Class_yearLevel,
                        Tutor = ce.Class.Tutor != null ? new
                        {
                            ce.Class.Tutor.Tutor_ID,
                            ce.Class.Tutor.Tutor_firstName,
                            ce.Class.Tutor.Tutor_LastName,
                            User = ce.Class.Tutor.User != null ? new
                            {
                                ce.Class.Tutor.User.User_ID,
                                ce.Class.Tutor.User.User_email,
                                ce.Class.Tutor.User.User_type
                            } : null
                        } : null
                    } : null,
                    Schedule = ce.ClassSchedule != null ? new
                    {
                        ce.ClassSchedule.Schedule_ID,
                        ce.ClassSchedule.DayOfWeek,
                        ce.ClassSchedule.StartTime,
                        ce.ClassSchedule.EndTime,
                        ce.ClassSchedule.Room
                    } : null
                })
            };

            return response;
        }

        // GET: api/Student/5/classes
        [HttpGet("{id}/classes")]
        public async Task<ActionResult<IEnumerable<Class>>> GetStudentClasses(int id)
        {
            var student = await _context.Students
                .Include(s => s.EnrolledClasses)
                .FirstOrDefaultAsync(s => s.Student_ID == id);

            if (student == null)
            {
                return NotFound();
            }

            return student.EnrolledClasses?.ToList() ?? new List<Class>();
        }

        // GET: api/Student/5/class-entries
        [HttpGet("{id}/class-entries")]
        public async Task<ActionResult<IEnumerable<ClassEntry>>> GetStudentClassEntries(int id)
        {
            return await _classEntryGenerator.GetStudentClassEntries(id);
        }

        // GET: api/Student/5/schedule
        [HttpGet("{id}/schedule")]
        public async Task<ActionResult<IEnumerable<ClassSchedule>>> GetStudentSchedule(int id)
        {
            var student = await _context.Students
                .Include(s => s.EnrolledClasses!)
                    .ThenInclude(c => c.Schedules)
                .FirstOrDefaultAsync(s => s.Student_ID == id);

            if (student == null)
            {
                return NotFound();
            }

            var schedules = student.EnrolledClasses?
                .Where(c => c.Schedules != null)
                .SelectMany(c => c.Schedules!)
                .ToList() ?? new List<ClassSchedule>();

            return schedules;
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
