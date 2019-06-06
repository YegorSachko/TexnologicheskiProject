using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Auction.Models;

namespace Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public LotsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Lots
        [HttpGet]
        public IEnumerable<Lot> GetLot()
        {
            return _context.Lots;
        }

        // GET: api/Lots/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLot([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lot = await _context.Lots.FindAsync(id);

            if (lot == null)
            {
                return NotFound();
            }


            return Ok(lot);
        }

        // PUT: api/Lots/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLot([FromRoute] int id, [FromBody] Lot lot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lot.LotID)
            {
                return BadRequest();
            }

            _context.Entry(lot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LotExists(id))
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

        // POST: api/Lots
        [HttpPost]
        public async Task<IActionResult> PostLot([FromBody] Lot lot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Lots.Add(lot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLot", new { id = lot.LotID }, lot);
        }

        // DELETE: api/Lots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLot([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lot = await _context.Lots.FindAsync(id);
            if (lot == null)
            {
                return NotFound();
            }

            _context.Lots.Remove(lot);
            await _context.SaveChangesAsync();

            return Ok(lot);
        }

        private bool LotExists(int id)
        {
            return _context.Lot.Any(e => e.LotID == id);
        }
    }
}