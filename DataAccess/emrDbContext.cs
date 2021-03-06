using EMR.Models;
using Microsoft.EntityFrameworkCore;

namespace EMR.DataAccess
{
    public class emrDbContext : DbContext
    {
        public emrDbContext(DbContextOptions<emrDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // decimal value precision
            modelBuilder.Entity<PRESCRIPTIONS>().Property(x => x.TEMPERATURE).HasPrecision(5, 2);
            modelBuilder.Entity<PRESCRIPTIONS>().Property(x => x.WEIGHT).HasPrecision(5, 2);
            modelBuilder.Entity<PRESCRIPTIONS>().Property(x => x.VISIT_FEES).HasPrecision(10, 2);
            modelBuilder.Entity<PRESCRIPTIONS_DRUGS>()
                .HasKey(c => new { c.PRESCRIPTIONS_ID, c.LINE_NO })
                .HasName("PK_PRESCRIPTIONS_DRUGS");
            modelBuilder.Entity<PRESCRIPTIONS_INVES>()
                .HasKey(c => new { c.PRESCRIPTIONS_ID, c.LINE_NO })
                .HasName("PK_PRESCRIPTIONS_INVES");
        }
        public DbSet<PATIENTS> PATIENTS { get; set; }
        public DbSet<DOCTORS> DOCTORS { get; set; }
        public DbSet<PRESCRIPTIONS> PRESCRIPTIONS { get; set; }
        public DbSet<PRESCRIPTIONS_DRUGS> PRESCRIPTIONS_DRUGS { get; set; }
        public DbSet<PRESCRIPTIONS_INVES> PRESCRIPTIONS_INVES { get; set; }
        public DbSet<SUBSCRIPTIONS> SUBSCRIPTIONS { get; set; }
        public DbSet<SEXS> SEXS { get; set; }
        public DbSet<DRUG_COMPANY_TYPES> DRUG_COMPANY_TYPES { get; set; }
        public DbSet<DRUG_COMPANYS> DRUG_COMPANYS { get; set; }
        public DbSet<DRUG_BRANDS> DRUG_BRANDS { get; set; }
        public DbSet<DRUG_CATEGORIES> DRUG_CATEGORIES { get; set; }
        public DbSet<DRUG_GENERICS> DRUG_GENERICS { get; set; }
        public DbSet<DRUGS> DRUGS { get; set; }
        public DbSet<DOCTOR_PRESCRIPTIONS> DOCTOR_PRESCRIPTIONS { get; set; }

    }

}
