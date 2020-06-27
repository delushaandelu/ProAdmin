using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAdminWebVersion.Models;

namespace ProAdminWebVersion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersDetailController : ControllerBase
    {
        private readonly ManageStudentDetailsContext _context;

        public UsersDetailController(ManageStudentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/UsersDetail
        [HttpGet]
        public IEnumerable<UsersDetail> GetUsersDetails()
        {
            return _context.UsersDetails;
        }

        // GET: api/UsersDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsersDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usersDetail = await _context.UsersDetails.FindAsync(id);

            if (usersDetail == null)
            {
                return NotFound();
            }

            return Ok(usersDetail);
        }

        // PUT: api/UsersDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsersDetail([FromRoute] int id, [FromBody] UsersDetail usersDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usersDetail.id)
            {
                return BadRequest();
            }

            _context.Entry(usersDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersDetailExists(id))
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

        // POST: api/UsersDetail
        [HttpPost]
        public async Task<IActionResult> PostUsersDetail([FromBody] UsersDetail usersDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UsersDetails.Add(usersDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsersDetail", new { id = usersDetail.id }, usersDetail);
        }

        // DELETE: api/UsersDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsersDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usersDetail = await _context.UsersDetails.FindAsync(id);
            if (usersDetail == null)
            {
                return NotFound();
            }

            _context.UsersDetails.Remove(usersDetail);
            await _context.SaveChangesAsync();

            return Ok(usersDetail);
        }

        private bool UsersDetailExists(int id)
        {
            return _context.UsersDetails.Any(e => e.id == id);
        }
    }
}