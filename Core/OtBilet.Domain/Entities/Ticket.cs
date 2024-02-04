using OtBilet.Domain.PNR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.Domain.Entities;
public class Ticket
{
    public string TicketID { get; set; } = Guid.NewGuid().ToString();
    public string PNR { get; set; }
    public int SeatNumber { get; set; }
    public int SeatID { get; set; }   
    public Seat Seat { get; set; }
    public string DestinationID { get; set; }
    public Destination Destination { get; set; }
    public List<Passenger> Passenger { get; set; }
    public void PNRGenerate(int length)
    {
        PNR = PNRGenerator.GeneratePNR(length);
    }
}
