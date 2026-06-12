using Microsoft.EntityFrameworkCore;
using Backend.Entities;

namespace Backend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set schema to 'resume' for all tables
            modelBuilder.Entity<Company>().ToTable("Companies", "resume");
            modelBuilder.Entity<Job>().ToTable("Jobs", "resume");
            modelBuilder.Entity<Candidate>().ToTable("Candidates", "resume");

            // Configure relationships
            modelBuilder.Entity<Job>()
                .HasOne(job => job.Company)
                .WithMany(company => company.Jobs)
                .HasForeignKey(job => job.CompanyId);

            modelBuilder.Entity<Candidate>()
                .HasOne(candidate => candidate.Job)
                .WithMany(job => job.Candidates)
                .HasForeignKey(candidate => candidate.JobId);
        }
    }
}
