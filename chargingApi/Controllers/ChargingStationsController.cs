using Microsoft.EntityFrameworkCore;
using chargingApi.Data;
using Microsoft.AspNetCore.Mvc;
using chargingApi.Models;



namespace ChargingStationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargingStationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChargingStationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ChargingStations (READ ALL)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChargingStation>>> GetChargingStations()
        {
            return await _context.ChargingStations.ToListAsync();
        }

        // GET: api/ChargingStations/5 (READ ONE - useful for Update form pre-fill)
        [HttpGet("{id}")]
        public async Task<ActionResult<ChargingStation>> GetChargingStation(int id)
        {
            var station = await _context.ChargingStations.FindAsync(id);

            if (station == null)
            {
                return NotFound();
            }
            return station;
        }

        // POST: api/ChargingStations (CREATE)
        [HttpPost]
        public async Task<ActionResult<ChargingStation>> PostChargingStation(ChargingStation station)
        {
            _context.ChargingStations.Add(station);
            await _context.SaveChangesAsync();

            // Returns HTTP 201 Created status
            return CreatedAtAction(nameof(GetChargingStation), new { id = station.Id }, station);
        }

        // PUT: api/ChargingStations/5 (UPDATE)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChargingStation(int id, ChargingStation station)
        {
            if (id != station.Id)
            {
                return BadRequest("ID mismatch.");
            }

            _context.Entry(station).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StationExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent(); // HTTP 204 No Content for successful update
        }

        // Helper function for PUT
        private bool StationExists(int id)
        {
            return _context.ChargingStations.Any(e => e.Id == id);
        }
    }
}