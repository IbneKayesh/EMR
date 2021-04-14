using EMR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.DataAccess
{
    public class emrDbContext:DbContext
    {
        public emrDbContext(DbContextOptions<emrDbContext> options) : base(options)
        {

        }
        public DbSet<SUBSCRIPTIONS> SUBSCRIPTIONS { get; set; }
        public DbSet<SEXS> SEXS { get; set; }
        public DbSet<DRUG_COMPANY_TYPES> DRUG_COMPANY_TYPES { get; set; }
        public DbSet<DRUG_COMPANYS> DRUG_COMPANYS { get; set; }
        public DbSet<DRUG_BRANDS> DRUG_BRANDS { get; set; }
        public DbSet<DRUG_CATEGORIES> DRUG_CATEGORIES { get; set; }
        public DbSet<DRUG_GENERICS> DRUG_GENERICS { get; set; }
        public DbSet<DRUGS> DRUGS { get; set; }

        public DbSet<DOCTORS> DOCTORS { get; set; }
        public DbSet<DOCTOR_PRESCRIPTIONS> DOCTOR_PRESCRIPTIONS { get; set; }
        public DbSet<PATIENTS> PATIENTS { get; set; }
    }

}
