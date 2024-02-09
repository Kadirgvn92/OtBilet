using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DTOLayer.TicketDTO;
public class CreateTicketDTO
{
    public string PNR { get; set; }
    public int SeatNumber { get; set; }
    public int PassengerID { get; set; }
    public Passenger Passenger { get; set; }
    public int DestinationID { get; set; }
    public Destination Destination { get; set; }
}
