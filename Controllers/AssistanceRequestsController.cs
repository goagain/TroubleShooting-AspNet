using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TroubleShooting_AspNet.Models;

namespace TroubleShooting_AspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistanceRequestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssistanceRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AssistanceRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssistanceRequest>>> GetassistanceRequest()
        {
            return await _context.AssistanceRequest.ToListAsync();
        }

        // GET: api/AssistanceRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssistanceRequest>> GetAssistanceRequest(int id)
        {
            var assistanceRequest = await _context.AssistanceRequest.FindAsync(id);

            if (assistanceRequest == null)
            {
                return NotFound();
            }

            return assistanceRequest;
        }

        // PUT: api/AssistanceRequests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssistanceRequest(int id, AssistanceRequest assistanceRequest)
        {
            if (id != assistanceRequest.ID)
            {
                return BadRequest();
            }

            _context.Entry(assistanceRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssistanceRequestExists(id))
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

        // POST: api/AssistanceRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssistanceRequest>> PostAssistanceRequest(AssistanceRequest assistanceRequest)
        {
            assistanceRequest.Date = DateTime.UtcNow;
            assistanceRequest.State = AssistanceRequestState.Received;

            _context.AssistanceRequest.Add(assistanceRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssistanceRequest", new { id = assistanceRequest.ID }, assistanceRequest);
        }

        // DELETE: api/AssistanceRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssistanceRequest(int id)
        {
            var assistanceRequest = await _context.AssistanceRequest.FindAsync(id);
            if (assistanceRequest == null)
            {
                return NotFound();
            }

            _context.AssistanceRequest.Remove(assistanceRequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssistanceRequestExists(int id)
        {
            return _context.AssistanceRequest.Any(e => e.ID == id);
        }
    }
}
