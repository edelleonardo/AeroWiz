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
    public class QuestionController : ControllerBase
    {
        private readonly AeroWizContext _context;

        public QuestionController(AeroWizContext context)
        {
            _context = context;
        }

        // GET: api/Question
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AerodynamicsConceptualQuestion>>> GetAerodynamicsConceptualQuestions()
        {
            return await _context.AerodynamicsConceptualQuestions.ToListAsync();
        }

        // GET: api/Question/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AerodynamicsConceptualQuestion>> GetAerodynamicsConceptualQuestion(int id)
        {
            var aerodynamicsConceptualQuestion = await _context.AerodynamicsConceptualQuestions.FindAsync(id);

            if (aerodynamicsConceptualQuestion == null)
            {
                return NotFound();
            }

            return aerodynamicsConceptualQuestion;
        }

        // PUT: api/Question/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAerodynamicsConceptualQuestion(int id, AerodynamicsConceptualQuestion aerodynamicsConceptualQuestion)
        {
            if (id != aerodynamicsConceptualQuestion.QuestionId)
            {
                return BadRequest();
            }

            _context.Entry(aerodynamicsConceptualQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AerodynamicsConceptualQuestionExists(id))
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

        // POST: api/Question
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AerodynamicsConceptualQuestion>> PostAerodynamicsConceptualQuestion(AerodynamicsConceptualQuestion aerodynamicsConceptualQuestion)
        {
            _context.AerodynamicsConceptualQuestions.Add(aerodynamicsConceptualQuestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAerodynamicsConceptualQuestion", new { id = aerodynamicsConceptualQuestion.QuestionId }, aerodynamicsConceptualQuestion);
        }

        // DELETE: api/Question/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAerodynamicsConceptualQuestion(int id)
        {
            var aerodynamicsConceptualQuestion = await _context.AerodynamicsConceptualQuestions.FindAsync(id);
            if (aerodynamicsConceptualQuestion == null)
            {
                return NotFound();
            }

            _context.AerodynamicsConceptualQuestions.Remove(aerodynamicsConceptualQuestion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AerodynamicsConceptualQuestionExists(int id)
        {
            return _context.AerodynamicsConceptualQuestions.Any(e => e.QuestionId == id);
        }
    }
}
