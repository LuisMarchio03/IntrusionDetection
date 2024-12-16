using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Src.Infrastructure.Persistence;

    public class AppDbContext : DbContext
    {
        // Define um DbSet para a entidade TrafficPacket
        public DbSet<TrafficPacket> TrafficPackets { get; set; }

        // Construtor que recebe as opções do contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Configurações adicionais do contexto
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração para a entidade TrafficPacket (se necessário)
            modelBuilder.Entity<TrafficPacket>(entity =>
            {
                entity.ToTable("TrafficPacket");
            });
        }
    }
