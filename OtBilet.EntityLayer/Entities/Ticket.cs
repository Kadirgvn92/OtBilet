﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtBilet.EntityLayer;
public class Ticket
{
    public int TicketID { get; set; } 
    public string PNR { get; set; }
    public int SeatNumber { get; set; }
    public int SeatID { get; set; }   
    public Seat Seat { get; set; }
    public int DestinationID { get; set; }
    public Destination Destination { get; set; }
    public List<Passenger> Passenger { get; set; }
    public void PNRGenerate(int length)
    {
        PNR = PNRGenerator.GeneratePNR(length);
    }
}