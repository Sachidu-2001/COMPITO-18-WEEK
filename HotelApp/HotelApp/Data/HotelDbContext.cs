using HotelApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace HotelApp.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Cliente> Clienti {  get; set; }
        public DbSet<Camera> Camere { get; set; }

        public DbSet<Prenotazione> Prenotazioni { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Prenotazione>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Prenotazioni)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Prenotazione>()
                .HasOne(p => p.Camera)
                .WithMany(c => c.Prenotazioni)
                .HasForeignKey(p => p.CameraId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}