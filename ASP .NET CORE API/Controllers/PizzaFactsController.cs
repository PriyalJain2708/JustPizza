using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaCoreApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaCoreApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PizzaFactsController : ControllerBase
    {
        private readonly DemoContext _context;

        public PizzaFactsController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/PizzaFacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaFact>>> GetPizzaFacts()
        {
            return await _context.PizzaFacts.ToListAsync();
        }

        // GET: api/PizzaFacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaFact>> GetPizzaFact(int id)
        {
            var pizzaFact = await _context.PizzaFacts.FindAsync(id);

            if (pizzaFact == null)
            {
                return NotFound();
            }

            return pizzaFact;
        }

        // PUT: api/PizzaFacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizzaFact(int id, PizzaFact pizzaFact)
        {
            if (id != pizzaFact.PizzaId)
            {
                return BadRequest();
            }

            _context.Entry(pizzaFact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaFactExists(id))
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

        // POST: api/PizzaFacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PizzaFact>> PostPizzaFact(PizzaFact pizzaFact)
        {
            _context.PizzaFacts.Add(pizzaFact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPizzaFact", new { id = pizzaFact.PizzaId }, pizzaFact);
        }

        // DELETE: api/PizzaFacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePizzaFact(int id)
        {
            var pizzaFact = await _context.PizzaFacts.FindAsync(id);
            if (pizzaFact == null)
            {
                return NotFound();
            }

            _context.PizzaFacts.Remove(pizzaFact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PizzaFactExists(int id)
        {
            return _context.PizzaFacts.Any(e => e.PizzaId == id);
        }
    }
}