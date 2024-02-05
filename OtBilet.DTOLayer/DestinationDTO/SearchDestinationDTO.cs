using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DTOLayer.DestinationDTO;
public class SearchDestinationDTO
{
    public Departure Departure { get; set; }
    public Arrive Arrive { get; set; }
    public DateTime DepatureDate { get; set; }
}
