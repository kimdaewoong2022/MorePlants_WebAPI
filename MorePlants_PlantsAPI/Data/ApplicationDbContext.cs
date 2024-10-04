using Microsoft.EntityFrameworkCore;
using MorePlants_PlantsAPI.Models;

namespace MorePlants_PlantsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
    }
}
