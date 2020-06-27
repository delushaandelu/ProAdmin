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
    public class UniversityDetailController : ControllerBase
    {
        private readonly ManageStudentDetailsContext _context;

        public UniversityDetailController(ManageStudentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/UniversityDetail
        [HttpGet]
        public IEnumerable<UniversityDetail> GetUniversityDetails()
        {
            return _context.UniversityDetails;
        }

        // GET: api/UniversityDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUniversityDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var universityDetail = await _context.UniversityDetails.FindAsync(id);

            if (universityDetail == null)
            {
                return NotFound();
            }

            return Ok(universityDetail);
        }

        // PUT: api/UniversityDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniversityDetail([FromRoute] int id, [FromBody] UniversityDetail universityDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != universityDetail.uniid)
            {
                return BadRequest();
            }

            _context.Entry(universityDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversityDetailExists(id))
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

        // POST: api/UniversityDetail
        [HttpPost]
        public async Task<IActionResult> PostUniversityDetail([FromBody] UniversityDetail universityDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UniversityDetails.Add(universityDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniversityDetail", new { id = universityDetail.uniid }, universityDetail);
        }

        // DELETE: api/UniversityDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUniversityDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var universityDetail = await _context.UniversityDetails.FindAsync(id);
            if (universityDetail == null)
            {
                return NotFound();
            }

            _context.UniversityDetails.Remove(universityDetail);
            await _context.SaveChangesAsync();

            return Ok(universityDetail);
        }

        private bool UniversityDetailExists(int id)
        {
            return _context.UniversityDetails.Any(e => e.uniid == id);
        }
    }
}