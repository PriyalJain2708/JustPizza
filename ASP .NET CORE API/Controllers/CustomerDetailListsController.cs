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
    public class CustomerDetailListsController : ControllerBase
    {
        private readonly DemoContext _context;

        public CustomerDetailListsController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/CustomerDetailLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDetailList>>> GetCustomerDetailLists()
        {
            return await _context.CustomerDetailLists.ToListAsync();
        }

        // GET: api/CustomerDetailLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetailList>> GetCustomerDetailList(string id)
        {
            var customerDetailList = await _context.CustomerDetailLists.FindAsync(id);

            if (customerDetailList == null)
            {
                return NotFound();
            }

            return customerDetailList;
        }

        // PUT: api/CustomerDetailLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerDetailList(string id, CustomerDetailList customerDetailList)
        {
            if (id != customerDetailList.CustomerName)
            {
                return BadRequest();
            }

            _context.Entry(customerDetailList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerDetailListExists(id))
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

        // POST: api/CustomerDetailLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerDetailList>> PostCustomerDetailList(CustomerDetailList customerDetailList)
        {
            _context.CustomerDetailLists.Add(customerDetailList);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustomerDetailListExists(customerDetailList.CustomerName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomerDetailList", new { id = customerDetailList.CustomerName }, customerDetailList);
        }

        // DELETE: api/CustomerDetailLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerDetailList(string id)
        {
            var customerDetailList = await _context.CustomerDetailLists.FindAsync(id);
            if (customerDetailList == null)
            {
                return NotFound();
            }

            _context.CustomerDetailLists.Remove(customerDetailList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerDetailListExists(string id)
        {
            return _context.CustomerDetailLists.Any(e => e.CustomerName == id);
        }
    }
}