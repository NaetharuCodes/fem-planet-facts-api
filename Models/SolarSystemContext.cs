using Microsoft.EntityFrameworkCore;
using SolarSystemAPI.Models;

public class SolarSystemContext : DbContext
{
    public SolarSystemContext(DbContextOptions<SolarSystemContext> options)
        : base(options) { }

    public DbSet<Planet> Planets { get; set; }
}
