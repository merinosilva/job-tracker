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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<JobApplicationProgress>(x => x.HasKey( k => new {k.ApplicationId, k.ProgressNo}));
            builder.Entity<JobApplicationProgress>().HasOne(p => p.Application).WithMany(a => a.progress).HasForeignKey(k => k.ApplicationId);
        }
    }
}