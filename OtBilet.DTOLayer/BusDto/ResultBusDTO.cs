using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DTOLayer.BusDto;
public class ResultBusDTO
{
    public int BusID { get; set; }
    public string Plate { get; set; }
    public int PassengerCount { get; set; }
    public bool Wifi { get; set; }
    public BusType BusType { get; set; }
}

public enum BusType
{
    [Display(Name = "2+1")]
    TwoplusOne = 0,
    [Display(Name = "2+2")]
    TwoplusTwo = 1,
}

