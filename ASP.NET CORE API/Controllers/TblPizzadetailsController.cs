using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCorePizza.Models;

namespace ApiCorePizza.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TblPizzadetailsController : ControllerBase
    {
        private readonly DemoContext _context;

        public TblPizzadetailsController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/TblPizzadetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblPizzadetail>>> GetTblPizzadetails()
        {
            return await _context.TblPizzadetails.ToListAsync();
        }

        // GET: api/TblPizzadetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPizzadetail>> GetTblPizzadetail(int id)
        {
            var tblPizzadetail = await _context.TblPizzadetails.FindAsync(id);

            if (tblPizzadetail == null)
            {
                return NotFound();
            }

            return tblPizzadetail;
        }

        // PUT: api/TblPizzadetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPizzadetail(int id, TblPizzadetail tblPizzadetail)
        {
            if (id != tblPizzadetail.PizzaId)
            {
                return BadRequest();
            }

            _context.Entry(tblPizzadetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPizzadetailExists(id))
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

        // POST: api/TblPizzadetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblPizzadetail>> PostTblPizzadetail(TblPizzadetail tblPizzadetail)
        {
            _context.TblPizzadetails.Add(tblPizzadetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblPizzadetailExists(tblPizzadetail.PizzaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblPizzadetail", new { id = tblPizzadetail.PizzaId }, tblPizzadetail);
        }

        // DELETE: api/TblPizzadetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblPizzadetail(int id)
        {
            var tblPizzadetail = await _context.TblPizzadetails.FindAsync(id);
            if (tblPizzadetail == null)
            {
                return NotFound();
            }

            _context.TblPizzadetails.Remove(tblPizzadetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblPizzadetailExists(int id)
        {
            return _context.TblPizzadetails.Any(e => e.PizzaId == id);
        }
    }
}
