using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DTOLayer.DestinationDTO;
public class CreateDestinationDTO
{
    public Departure Departure { get; set; }
    public Arrive Arrive { get; set; }
    public DateTime DepatureDate { get; set; }
    public TimeSpan DepartureHour { get; set; }
    public decimal Price { get; set; }
    public int BusID { get; set; }
}
