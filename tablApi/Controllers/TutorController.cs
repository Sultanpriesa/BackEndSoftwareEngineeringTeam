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
    public class TutorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TutorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tutor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> GetTutors()
        {
            return await _context.Tutors.ToListAsync();
        }

        // GET: api/Tutor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tutor>> GetTutor(int id)
        {
            var tutor = await _context.Tutors.FindAsync(id);

            if (tutor == null)
            {
                return NotFound();
            }

            return tutor;
        }

        // PUT: api/Tutor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutor(int id, Tutor tutor)
        {
            if (id != tutor.Tutor_ID)
            {
                return BadRequest();
            }

            _context.Entry(tutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorExists(id))
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

        // POST: api/Tutor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tutor>> PostTutor(Tutor tutor)
        {
            _context.Tutors.Add(tutor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTutor", new { id = tutor.Tutor_ID }, tutor);
        }

        // DELETE: api/Tutor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTutor(int id)
        {
            var tutor = await _context.Tutors.FindAsync(id);
            if (tutor == null)
            {
                return NotFound();
            }

            _context.Tutors.Remove(tutor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TutorExists(int id)
        {
            return _context.Tutors.Any(e => e.Tutor_ID == id);
        }
    }
}
