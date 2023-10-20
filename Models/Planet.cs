// Models/Planet.cs
namespace SolarSystemAPI.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RotationTime { get; set; }
        public int Radius { get; set; }
        public int RevolutionTime { get; set; }
        public int Temperature { get; set; }  
    }
}
