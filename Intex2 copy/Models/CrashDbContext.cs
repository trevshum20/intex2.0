using System;
using Microsoft.EntityFrameworkCore;

namespace Intex2.Models
{
    public class CrashDbContext : DbContext
    {
        public CrashDbContext(DbContextOptions<CrashDbContext> options) : base(options)
        {

        }

        public DbSet<utah_crashes> Crashes { get; set; }
        public DbSet<Severity> Severities { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Severity>().HasData(
                new Severity { SeverityId = 1, Name = "No Injury" },
                new Severity { SeverityId = 2, Name = "Possible Injury" },
                new Severity { SeverityId = 3, Name = "Suspected Minor Injury" },
                new Severity { SeverityId = 4, Name = "Suspected Serious Injury" },
                new Severity { SeverityId = 5, Name = "Fatal" }
            );
        }
}
