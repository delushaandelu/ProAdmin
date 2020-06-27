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
    public class SubjectDetailController : ControllerBase
    {
        private readonly ManageStudentDetailsContext _context;

        public SubjectDetailController(ManageStudentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/SubjectDetail
        [HttpGet]
        public IEnumerable<SubjectDetail> GetSubjectDetails()
        {
            return _context.SubjectDetails;
        }

        // GET: api/SubjectDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubjectDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subjectDetail = await _context.SubjectDetails.FindAsync(id);

            if (subjectDetail == null)
            {
                return NotFound();
            }

            return Ok(subjectDetail);
        }

        // PUT: api/SubjectDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubjectDetail([FromRoute] int id, [FromBody] SubjectDetail subjectDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subjectDetail.subid)
            {
                return BadRequest();
            }

            _context.Entry(subjectDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectDetailExists(id))
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

        // POST: api/SubjectDetail
        [HttpPost]
        public async Task<IActionResult> PostSubjectDetail([FromBody] SubjectDetail subjectDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SubjectDetails.Add(subjectDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubjectDetail", new { id = subjectDetail.subid }, subjectDetail);
        }

        // DELETE: api/SubjectDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubjectDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subjectDetail = await _context.SubjectDetails.FindAsync(id);
            if (subjectDetail == null)
            {
                return NotFound();
            }

            _context.SubjectDetails.Remove(subjectDetail);
            await _context.SaveChangesAsync();

            return Ok(subjectDetail);
        }

        private bool SubjectDetailExists(int id)
        {
            return _context.SubjectDetails.Any(e => e.subid == id);
        }
    }
}