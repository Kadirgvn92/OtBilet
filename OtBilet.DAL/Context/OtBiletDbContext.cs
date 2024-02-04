using Microsoft.EntityFrameworkCore;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.Context;
public class OtBiletDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-A6C5CRN\\MSSQLSERVER01;Database=OtBiletDb;integrated Security=true;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Seat)
            .WithMany()
            .HasForeignKey(t => t.SeatID)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Seat>()
           .HasMany(s => s.Tickets)
           .WithOne(t => t.Seat)
           .HasForeignKey(t => t.SeatID)
           .OnDelete(DeleteBehavior.NoAction);
    }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    
}
