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
    public class StudentsDetailController : ControllerBase
    {
        private readonly ManageStudentDetailsContext _context;

        public StudentsDetailController(ManageStudentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/StudentsDetail
        [HttpGet]
        public IEnumerable<StudentsDetail> GetStudentDetails()
        {
            return _context.StudentDetails;
        }

        // GET: api/StudentsDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentsDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentsDetail = await _context.StudentDetails.FindAsync(id);

            if (studentsDetail == null)
            {
                return NotFound();
            }

            return Ok(studentsDetail);
        }

        // PUT: api/StudentsDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentsDetail([FromRoute] int id, [FromBody] StudentsDetail studentsDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentsDetail.Sid)
            {
                return BadRequest();
            }

            _context.Entry(studentsDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsDetailExists(id))
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

        // POST: api/StudentsDetail
        [HttpPost]
        public async Task<IActionResult> PostStudentsDetail([FromBody] StudentsDetail studentsDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.StudentDetails.Add(studentsDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentsDetail", new { id = studentsDetail.Sid }, studentsDetail);
        }

        // DELETE: api/StudentsDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentsDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentsDetail = await _context.StudentDetails.FindAsync(id);
            if (studentsDetail == null)
            {
                return NotFound();
            }

            _context.StudentDetails.Remove(studentsDetail);
            await _context.SaveChangesAsync();

            return Ok(studentsDetail);
        }

        private bool StudentsDetailExists(int id)
        {
            return _context.StudentDetails.Any(e => e.Sid == id);
        }
    }
}