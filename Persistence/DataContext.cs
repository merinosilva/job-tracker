using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<JobApplication> Applications { get; set; }
        public DbSet<JobApplicationProgress> Progresses { get; set; }
    }
}