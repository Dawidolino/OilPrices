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
    [Route("api/fuelstation")]
    [ApiController]
    public class FuelStationsController : ControllerBase
    {
        private readonly OilPricesAppContext _context;

        public FuelStationsController(OilPricesAppContext context)
        {
            _context = context;
        }

        // GET: api/FuelStations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuelStation>>> GetFuelStations()
        {
          if (_context.FuelStations == null)
          {
              return NotFound();
          }
            return await _context.FuelStations.ToListAsync();
        }

        // GET: api/FuelStations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuelStation>> GetFuelStation(short id)
        {
          if (_context.FuelStations == null)
          {
              return NotFound();
          }
            var fuelStation = await _context.FuelStations.FindAsync(id);

            if (fuelStation == null)
            {
                return NotFound();
            }

            return fuelStation;
        }

        // PUT: api/FuelStations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuelStation(short id, FuelStation fuelStation)
        {
            if (id != fuelStation.Id)
            {
                return BadRequest();
            }

            _context.Entry(fuelStation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuelStationExists(id))
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

        // POST: api/FuelStations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FuelStation>> PostFuelStation(FuelStation fuelStation)
        {
          if (_context.FuelStations == null)
          {
              return Problem("Entity set 'OilPricesAppContext.FuelStations'  is null.");
          }
            _context.FuelStations.Add(fuelStation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FuelStationExists(fuelStation.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFuelStation", new { id = fuelStation.Id }, fuelStation);
        }

        // DELETE: api/FuelStations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFuelStation(short id)
        {
            if (_context.FuelStations == null)
            {
                return NotFound();
            }
            var fuelStation = await _context.FuelStations.FindAsync(id);
            if (fuelStation == null)
            {
                return NotFound();
            }

            _context.FuelStations.Remove(fuelStation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuelStationExists(short id)
        {
            return (_context.FuelStations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
