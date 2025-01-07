using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.Domain;
namespace WebApplication2.Data
{
    public class TheDBContext: DbContext
    {
        public TheDBContext(DbContextOptions dbContextOptions) :  base(dbContextOptions)
        {
                
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

    }
}
