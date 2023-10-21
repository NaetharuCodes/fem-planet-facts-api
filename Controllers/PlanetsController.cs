// Controllers/PlanetsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolarSystemAPI.Models;

namespace SolarSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsController : ControllerBase
    {
        private readonly SolarSystemContext _context;

        public PlanetsController(SolarSystemContext context)
        {
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Planet>> GetPlanetByName(string name)
        {
            var planet = await _context.Planets.FirstOrDefaultAsync(
                p => p.Name.ToLower() == name.ToLower()
            );

            if (planet == null)
            {
                return NotFound($"Planet with name {name} not found.");
            }

            return Ok(planet);
        }
    }
}
