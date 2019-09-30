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
    public class BitsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public BitsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Bits
        [HttpGet]
        public IEnumerable<Bit> GetBits()
        {
            return _context.Bits;
        }

        // GET: api/Bits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBit([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bit = await _context.Bits.FindAsync(id);

            if (bit == null)
            {
                return NotFound();
            }

            return Ok(bit);
        }

        // PUT: api/Bits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBit([FromRoute] int id, [FromBody] Bit bit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bit.Id)
            {
                return BadRequest();
            }

            _context.Entry(bit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BitExists(id))
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

        // POST: api/Bits
        [HttpPost]
        public async Task<IActionResult> PostBit([FromBody] Bit bit)
            {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _context.Bits.Add(bit);
                var lot = await _context.Lots.FindAsync(bit.LotId);
                lot.Lotprice = bit.Price;
                _context.Entry(lot).State = EntityState.Modified;

                _context.Update(lot);
                await _context.SaveChangesAsync();
            return Ok(bit);
            }
            catch (Exception ex)
            {
                var test = ex;
            }
            return Ok(bit);
            //return CreatedAtAction("GetBit", new { id = bit.Id }, bit);
        }


        // DELETE: api/Bits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBit([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bit = await _context.Bits.FindAsync(id);
            if (bit == null)
            {
                return NotFound();
            }

            _context.Bits.Remove(bit);
            await _context.SaveChangesAsync();

            return Ok(bit);
        }

        private bool BitExists(int id)
        {
            return _context.Bits.Any(e => e.Id == id);
        }
    }
}