using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tablApi.Data;
using tablApi.Model;
using tablApi.Services;

namespace tablApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StaffController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ClassEntryGenerator _classEntryGenerator;

    public StaffController(ApplicationDbContext context, ClassEntryGenerator classEntryGenerator)
    {
        _context = context;
        _classEntryGenerator = classEntryGenerator;
    }

    // Get all tutors
    [HttpGet("tutors")]
    public async Task<ActionResult<IEnumerable<Tutor>>> GetTutors()
    {
        return await _context.Tutors
            .Include(t => t.User)
            .Include(t => t.Courses)
            .ToListAsync();
    }

    // Get tutor by ID
    [HttpGet("tutors/{id}")]
    public async Task<ActionResult<Tutor>> GetTutor(int id)
    {
        var tutor = await _context.Tutors
            .Include(t => t.User)
            .Include(t => t.Courses)
            .FirstOrDefaultAsync(t => t.Tutor_ID == id);

        if (tutor == null)
        {
            return NotFound();
        }

        return tutor;
    }

    // Get tutor's classes
    [HttpGet("tutors/{id}/classes")]
    public async Task<ActionResult<IEnumerable<Class>>> GetTutorClasses(int id)
    {
        var tutor = await _context.Tutors
            .Include(t => t.Courses)
            .FirstOrDefaultAsync(t => t.Tutor_ID == id);

        if (tutor == null)
        {
            return NotFound();
        }

        return tutor.Courses?.ToList() ?? new List<Class>();
    }

    // Get class details with enrolled students
    [HttpGet("classes/{id}")]
    public async Task<ActionResult<Class>> GetClassDetails(int id)
    {
        var classDetails = await _context.Classes
            .Include(c => c.Tutor)
            .Include(c => c.EnrolledStudents)
            .Include(c => c.Schedules)
            .FirstOrDefaultAsync(c => c.Class_ID == id);

        if (classDetails == null)
        {
            return NotFound();
        }

        return classDetails;
    }

    // Get class entries for a class
    [HttpGet("classes/{id}/entries")]
    public async Task<ActionResult<IEnumerable<ClassEntry>>> GetClassEntries(int id)
    {
        var entries = await _context.ClassEntries
            .Include(ce => ce.Students)
            .Where(ce => ce.Class_ID == id)
            .ToListAsync();

        return entries;
    }

    // Toggle class entry deleted status
    [HttpPut("class-entries/{id}/toggle-deleted")]
    public async Task<IActionResult> ToggleClassEntryDeleted(int id)
    {
        await _classEntryGenerator.ToggleClassEntryDeleted(id);
        return NoContent();
    }

    // Create new class
    [HttpPost("classes")]
    public async Task<ActionResult<Class>> CreateClass(Class newClass)
    {
        _context.Classes.Add(newClass);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetClassDetails), new { id = newClass.Class_ID }, newClass);
    }

    // Update class
    [HttpPut("classes/{id}")]
    public async Task<IActionResult> UpdateClass(int id, Class updatedClass)
    {
        if (id != updatedClass.Class_ID)
        {
            return BadRequest();
        }

        _context.Entry(updatedClass).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ClassExists(id))
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

    // Add schedule to class
    [HttpPost("classes/{id}/schedules")]
    public async Task<ActionResult<ClassSchedule>> AddClassSchedule(int id, ClassSchedule schedule)
    {
        var classEntity = await _context.Classes.FindAsync(id);
        if (classEntity == null)
        {
            return NotFound();
        }

        schedule.Class_ID = id;
        _context.ClassSchedules.Add(schedule);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetClassDetails), new { id = id }, schedule);
    }

    // Update class schedule
    [HttpPut("schedules/{id}")]
    public async Task<IActionResult> UpdateClassSchedule(int id, ClassSchedule schedule)
    {
        if (id != schedule.Schedule_ID)
        {
            return BadRequest();
        }

        _context.Entry(schedule).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ScheduleExists(id))
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

    // Delete class schedule
    [HttpDelete("schedules/{id}")]
    public async Task<IActionResult> DeleteClassSchedule(int id)
    {
        var schedule = await _context.ClassSchedules.FindAsync(id);
        if (schedule == null)
        {
            return NotFound();
        }

        _context.ClassSchedules.Remove(schedule);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // Delete class entry
    [HttpDelete("class-entries/{id}")]
    public async Task<IActionResult> DeleteClassEntry(int id)
    {
        var entry = await _context.ClassEntries.FindAsync(id);
        if (entry == null)
        {
            return NotFound();
        }

        // Remove student associations first
        await _context.Database.ExecuteSqlRawAsync(
            "DELETE FROM ClassEntryStudents WHERE ClassEntriesClassEntry_ID = {0}",
            id
        );

        _context.ClassEntries.Remove(entry);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ClassExists(int id)
    {
        return _context.Classes.Any(e => e.Class_ID == id);
    }

    private bool ScheduleExists(int id)
    {
        return _context.ClassSchedules.Any(e => e.Schedule_ID == id);
    }
} 