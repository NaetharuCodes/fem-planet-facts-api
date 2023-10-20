// Services/PlanetService.cs
using SolarSystemAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SolarSystemAPI.Services
{
    public class PlanetService
    {
        private readonly List<Planet> _planets = new()
        {
            new Planet { Id = 1, Name = "Mercury", Description = "A description of the planet", RotationTime = 123, Radius = 321, RevolutionTime = 787, Temperature = 9923 },
            // ... Add other planets here
        };
        public IEnumerable<Planet> GetAll() => _planets;

        public Planet GetById(int id) => _planets.FirstOrDefault(p => p.Id == id);
    }
}
