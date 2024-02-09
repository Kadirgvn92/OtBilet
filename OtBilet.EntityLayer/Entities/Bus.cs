using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.EntityLayer;
public class Bus
{
    public int BusID { get; set; }
    public string Plate { get; set; }
    public int PassengerCount { get; set; }
    public string FirmName { get; set; }
    public string FirmImageUrl { get; set; }
    public bool Wifi { get; set; }
    public BusType BusType { get; set; }
    public List<Destination> Destinations { get; set; }
    public List<Seat> Seat { get; set; }
}

public enum BusType
{
    [Display(Name = "2+1")]
    TwoplusOne = 0,
    [Display(Name = "2+2")]
    TwoplusTwo = 1,
}
