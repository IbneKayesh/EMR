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
        public DbSet<PATIENTS> PATIENTS { get; set; }
        public DbSet<DOCTORS> DOCTORS { get; set; }
    }

}
