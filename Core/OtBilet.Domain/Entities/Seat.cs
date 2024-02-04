using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.Domain.Entities;
public class Seat
{
    public int SeatID { get; set; } 
    public int SeatNumber { get; set; }
    public bool IsAvailable { get; set; }
    public string BusID { get; set; }
    public Bus Bus { get; set; }
    public List<Ticket> Tickets { get; set; }
}
