using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DTOLayer.BusDto;
public class CreateBusDTO
{
    public string Plate { get; set; }
    public int PassengerCount { get; set; }
    public bool Wifi { get; set; }
    public BusType BusType { get; set; }
}

