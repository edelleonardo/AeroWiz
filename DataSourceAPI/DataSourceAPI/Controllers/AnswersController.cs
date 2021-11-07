using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataSourceAPI.Models;

namespace DataSourceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly AeroWizContext _context;

        public AnswersController(AeroWizContext context)
        {
            _context = context;
        }

        // GET: api/Answers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AerodynamicsConceptualAnswer>>> GetAerodynamicsConceptualAnswers()
        {
            return await _context.AerodynamicsConceptualAnswers.ToListAsync();
        }

        // GET: api/Answers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AerodynamicsConceptualAnswer>> GetAerodynamicsConceptualAnswer(int id)
        {
            var aerodynamicsConceptualAnswer = await _context.AerodynamicsConceptualAnswers.FindAsync(id);

            if (aerodynamicsConceptualAnswer == null)
            {
                return NotFound();
            }

            return aerodynamicsConceptualAnswer;
        }

        // PUT: api/Answers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAerodynamicsConceptualAnswer(int id, AerodynamicsConceptualAnswer aerodynamicsConceptualAnswer)
        {
            if (id != aerodynamicsConceptualAnswer.AnswerId)
            {
                return BadRequest();
            }

            _context.Entry(aerodynamicsConceptualAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AerodynamicsConceptualAnswerExists(id))
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

        // POST: api/Answers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AerodynamicsConceptualAnswer>> PostAerodynamicsConceptualAnswer(AerodynamicsConceptualAnswer aerodynamicsConceptualAnswer)
        {
            _context.AerodynamicsConceptualAnswers.Add(aerodynamicsConceptualAnswer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAerodynamicsConceptualAnswer", new { id = aerodynamicsConceptualAnswer.AnswerId }, aerodynamicsConceptualAnswer);
        }

        // DELETE: api/Answers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAerodynamicsConceptualAnswer(int id)
        {
            var aerodynamicsConceptualAnswer = await _context.AerodynamicsConceptualAnswers.FindAsync(id);
            if (aerodynamicsConceptualAnswer == null)
            {
                return NotFound();
            }

            _context.AerodynamicsConceptualAnswers.Remove(aerodynamicsConceptualAnswer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AerodynamicsConceptualAnswerExists(int id)
        {
            return _context.AerodynamicsConceptualAnswers.Any(e => e.AnswerId == id);
        }
    }
}
