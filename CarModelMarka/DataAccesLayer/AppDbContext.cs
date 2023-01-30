using CarModelMarka.Models;
using Microsoft.EntityFrameworkCore;

namespace CarModelMarka.DataAccesLayer
{
   
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
        public DbSet<Marka> Markas { get; set; }



    }

}
