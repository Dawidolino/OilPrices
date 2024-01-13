using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OilPrices.Models;

namespace OilPrices.Controllers
{
    [Route("api/[fuelprices]")]
    [ApiController]
    public class FuelPricesController : ControllerBase
    {
        private readonly OilPricesAppContext _context;

        public FuelPricesController(OilPricesAppContext context)
        {
            _context = context;
        }

        // GET: api/FuelPrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuelPrices>>> GetFuelPrices()
        {
          if (_context.FuelPrices == null)
          {
              return NotFound();
          }
            return await _context.FuelPrices.ToListAsync();
        }

        // GET: api/FuelPrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuelPrices>> GetFuelPrices(short id)
        {
          if (_context.FuelPrices == null)
          {
              return NotFound();
          }
            var fuelPrices = await _context.FuelPrices.FindAsync(id);

            if (fuelPrices == null)
            {
                return NotFound();
            }

            return fuelPrices;
        }

        // PUT: api/FuelPrices/5        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuelPrices(short id, FuelPrices fuelPrices)
        {
            if (id != fuelPrices.Id)
            {
                return BadRequest();
            }

            _context.Entry(fuelPrices).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuelPricesExists(id))
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

        // POST: api/FuelPrices
        [HttpPost]
        public async Task<ActionResult<FuelPrices>> PostFuelPrices(FuelPrices fuelPrices)
        {
          if (_context.FuelPrices == null)
          {
              return Problem("Entity set 'OilPricesAppContext.FuelPrices'  is null.");
          }
            _context.FuelPrices.Add(fuelPrices);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuelPrices", new { id = fuelPrices.Id }, fuelPrices);
        }

        // DELETE: api/FuelPrices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFuelPrices(short id)
        {
            if (_context.FuelPrices == null)
            {
                return NotFound();
            }
            var fuelPrices = await _context.FuelPrices.FindAsync(id);
            if (fuelPrices == null)
            {
                return NotFound();
            }

            _context.FuelPrices.Remove(fuelPrices);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuelPricesExists(short id)
        {
            return (_context.FuelPrices?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
