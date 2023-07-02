using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class PawpalDbContext : DbContext
    {
        public PawpalDbContext(DbContextOptions<PawpalDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pawbond>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<Pawbond>()
                .HasOne(f => f.Author)
                .WithMany(u => u.Pawbonds)
                .HasForeignKey(f => f.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pawbond>()
                .HasOne(f => f.Partner)
                .WithMany()
                .HasForeignKey(f => f.PartnerId)
                .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Pawpal> Pawpals { get; set; }
        public DbSet<Pawbond> Pawbonds { get; set; }
        public DbSet<PawbondPost> PawbondPosts { get; set; }

    }
}
