using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OtBilet.EntityLayer;
using OtBilet.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.Context;
public class OtBiletDbContext : IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-A6C5CRN\\MSSQLSERVER01;Database=OtBiletDb;integrated Security=true;TrustServerCertificate=True;");
    }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
