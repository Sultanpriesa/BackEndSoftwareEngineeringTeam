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
    public class ClassEntryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassEntryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ClassEntry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassEntry>>> GetClassEntries()
        {
            return await _context.ClassEntries.ToListAsync();
        }

        // GET: api/ClassEntry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassEntry>> GetClassEntry(int id)
        {
            var classEntry = await _context.ClassEntries.FindAsync(id);

            if (classEntry == null)
            {
                return NotFound();
            }

            return classEntry;
        }

        // PUT: api/ClassEntry/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassEntry(int id, ClassEntry classEntry)
        {
            if (id != classEntry.ClassEntry_ID)
            {
                return BadRequest();
            }

            _context.Entry(classEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassEntryExists(id))
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

        // POST: api/ClassEntry
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClassEntry>> PostClassEntry(ClassEntry classEntry)
        {
            _context.ClassEntries.Add(classEntry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassEntry", new { id = classEntry.ClassEntry_ID }, classEntry);
        }

        // DELETE: api/ClassEntry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassEntry(int id)
        {
            var classEntry = await _context.ClassEntries.FindAsync(id);
            if (classEntry == null)
            {
                return NotFound();
            }

            _context.ClassEntries.Remove(classEntry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassEntryExists(int id)
        {
            return _context.ClassEntries.Any(e => e.ClassEntry_ID == id);
        }
    }
}
