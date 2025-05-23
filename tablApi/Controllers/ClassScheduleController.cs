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
    public class ClassScheduleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ClassSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassSchedule>>> GetClassSchedules()
        {
            return await _context.ClassSchedules.ToListAsync();
        }

        // GET: api/ClassSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassSchedule>> GetClassSchedule(int id)
        {
            var classSchedule = await _context.ClassSchedules.FindAsync(id);

            if (classSchedule == null)
            {
                return NotFound();
            }

            return classSchedule;
        }

        // PUT: api/ClassSchedule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassSchedule(int id, ClassSchedule classSchedule)
        {
            if (id != classSchedule.Schedule_ID)
            {
                return BadRequest();
            }

            _context.Entry(classSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassScheduleExists(id))
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

        // POST: api/ClassSchedule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClassSchedule>> PostClassSchedule(ClassSchedule classSchedule)
        {
            _context.ClassSchedules.Add(classSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassSchedule", new { id = classSchedule.Schedule_ID }, classSchedule);
        }

        // DELETE: api/ClassSchedule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassSchedule(int id)
        {
            var classSchedule = await _context.ClassSchedules.FindAsync(id);
            if (classSchedule == null)
            {
                return NotFound();
            }

            _context.ClassSchedules.Remove(classSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassScheduleExists(int id)
        {
            return _context.ClassSchedules.Any(e => e.Schedule_ID == id);
        }
    }
}
