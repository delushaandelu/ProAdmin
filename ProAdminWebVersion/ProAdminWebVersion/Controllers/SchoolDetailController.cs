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
    public class SchoolDetailController : ControllerBase
    {
        private readonly ManageStudentDetailsContext _context;

        public SchoolDetailController(ManageStudentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/SchoolDetail
        [HttpGet]
        public IEnumerable<SchoolDetail> GetSchoolDetails()
        {
            return _context.SchoolDetails;
        }

        // GET: api/SchoolDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSchoolDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var schoolDetail = await _context.SchoolDetails.FindAsync(id);

            if (schoolDetail == null)
            {
                return NotFound();
            }

            return Ok(schoolDetail);
        }

        // PUT: api/SchoolDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchoolDetail([FromRoute] int id, [FromBody] SchoolDetail schoolDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != schoolDetail.schid)
            {
                return BadRequest();
            }

            _context.Entry(schoolDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolDetailExists(id))
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

        // POST: api/SchoolDetail
        [HttpPost]
        public async Task<IActionResult> PostSchoolDetail([FromBody] SchoolDetail schoolDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SchoolDetails.Add(schoolDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchoolDetail", new { id = schoolDetail.schid }, schoolDetail);
        }

        // DELETE: api/SchoolDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchoolDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var schoolDetail = await _context.SchoolDetails.FindAsync(id);
            if (schoolDetail == null)
            {
                return NotFound();
            }

            _context.SchoolDetails.Remove(schoolDetail);
            await _context.SaveChangesAsync();

            return Ok(schoolDetail);
        }

        private bool SchoolDetailExists(int id)
        {
            return _context.SchoolDetails.Any(e => e.schid == id);
        }
    }
}