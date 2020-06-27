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
    public class BatchDetailController : ControllerBase
    {
        private readonly ManageStudentDetailsContext _context;

        public BatchDetailController(ManageStudentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/BatchDetail
        [HttpGet]
        public IEnumerable<BatchDetail> GetBatchDetails()
        {
            return _context.BatchDetails;
        }

        // GET: api/BatchDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBatchDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var batchDetail = await _context.BatchDetails.FindAsync(id);

            if (batchDetail == null)
            {
                return NotFound();
            }

            return Ok(batchDetail);
        }

        // PUT: api/BatchDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBatchDetail([FromRoute] int id, [FromBody] BatchDetail batchDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != batchDetail.batchid)
            {
                return BadRequest();
            }

            _context.Entry(batchDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BatchDetailExists(id))
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

        // POST: api/BatchDetail
        [HttpPost]
        public async Task<IActionResult> PostBatchDetail([FromBody] BatchDetail batchDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BatchDetails.Add(batchDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBatchDetail", new { id = batchDetail.batchid }, batchDetail);
        }

        // DELETE: api/BatchDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBatchDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var batchDetail = await _context.BatchDetails.FindAsync(id);
            if (batchDetail == null)
            {
                return NotFound();
            }

            _context.BatchDetails.Remove(batchDetail);
            await _context.SaveChangesAsync();

            return Ok(batchDetail);
        }

        private bool BatchDetailExists(int id)
        {
            return _context.BatchDetails.Any(e => e.batchid == id);
        }
    }
}