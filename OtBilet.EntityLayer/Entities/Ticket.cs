using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using OtBilet.EntityLayer.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtBilet.EntityLayer;
public class Ticket
{
    public int TicketID { get; set; } 
    public string PNR { get; set; }
    public int SeatNumber { get; set; }
    public int DestinationID { get; set; }
    public Destination Destination { get; set; }
    public int AppUserID { get; set; }
    public AppUser AppUser { get; set; }
}
