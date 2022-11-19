using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BugTrackerContext : DbContext
    {
        public DbSet<Bugs> Bugs { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Priorities> Priorities { get; set; }
        public DbSet<Severities> Severities { get; set; }
        public DbSet<Messages> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BHR\\SQL2019EXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial catalog=BugTracker;");
        }
    }
}
