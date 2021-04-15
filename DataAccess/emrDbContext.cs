using EMR.Models;
using Microsoft.EntityFrameworkCore;

namespace EMR.DataAccess
{
    public class emrDbContext : DbContext
    {
        public emrDbContext(DbContextOptions<emrDbContext> options) : base(options)
        {

        }
        public DbSet<PATIENTS> PATIENTS { get; set; }
        public DbSet<DOCTORS> DOCTORS { get; set; }
    }

}
