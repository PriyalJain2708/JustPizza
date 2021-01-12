using ApiCorePizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCorePizza.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly DemoContext _context;

        public UserDetailsController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/UserDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDetail>>> GetUserDetails()
        {
            return await _context.UserDetails.ToListAsync();
        }

        // GET: api/UserDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDetail>> GetUserDetail(string id)
        {
            var userDetail = await _context.UserDetails.FindAsync(id);

            if (userDetail == null)
            {
                return NotFound();
            }

            return userDetail;
        }

        // PUT: api/UserDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserDetail(string id, UserDetail userDetail)
        {
            if (id != userDetail.UserName)
            {
                return BadRequest();
            }

            _context.Entry(userDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDetailExists(id))
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

        // POST: api/UserDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserDetail>> PostUserDetail(UserDetail userDetail)
        {
            _context.UserDetails.Add(userDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserDetailExists(userDetail.UserName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserDetail", new { id = userDetail.UserName }, userDetail);
        }

        // DELETE: api/UserDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserDetail(string id)
        {
            var userDetail = await _context.UserDetails.FindAsync(id);
            if (userDetail == null)
            {
                return NotFound();
            }

            _context.UserDetails.Remove(userDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserDetailExists(string id)
        {
            return _context.UserDetails.Any(e => e.UserName == id);
        }
    }
}
