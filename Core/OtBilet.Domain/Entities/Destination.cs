using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.Domain.Entities;
public class Destination 
{
    public string DestinationID { get; set; } = Guid.NewGuid().ToString();
    public Departure Departure {  get; set; }
    public Arrive Arrive { get; set; }
    public DateTime DepatureDate { get; set; }
    public TimeSpan DepartureHour { get; set; }
    public decimal Price { get; set; }
    public string BusID { get; set; }
    public Bus Bus { get; set; }
    public List<Ticket> Tickets { get; set; }
}
public enum Departure
{
    Istanbul,
    Ankara,
    Izmir,
    Antalya,
    Bursa,
    Adana,
    Eskisehir,
    // Diğer şehirler...
}

public enum Arrive
{
    Istanbul,
    Ankara,
    Izmir,
    Antalya,
    Bursa,
    Adana,
    Eskisehir,
    // Diğer şehirler...
}
