// Controllers/PlanetsController.cs
using Microsoft.AspNetCore.Mvc;
using SolarSystemAPI.Models;
using SolarSystemAPI.Services;

namespace SolarSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsController : ControllerBase
    {
        private readonly PlanetService _planetService;

        public PlanetsController()
        {
            _planetService = new PlanetService();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Planet>> Get() => Ok(_planetService.GetAll());

        [HttpGet("{id}")]
        public ActionResult<Planet> Get(int id)
        {
            var planet = _planetService.GetById(id);
            if (planet == null) return NotFound();
            return Ok(planet);
        }
    }
}
