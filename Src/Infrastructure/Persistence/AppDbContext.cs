using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Src.Infrastructure.Persistence;

    public class AppDbContext : DbContext
    {
        public DbSet<TrafficPacket> TrafficPackets { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrafficPacket>()
                .HasKey(p => p.Id);
        }
    }
