using Microsoft.EntityFrameworkCore;
using MorePlants_PlantsAPI.Models;

namespace MorePlants_PlantsAPI.Data
{    
    public class ApplicationDbContext : DbContext
    {
        //4-5. 연결 문자열 사용
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }
    }
}
