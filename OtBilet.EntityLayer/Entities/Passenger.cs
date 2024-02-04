﻿namespace OtBilet.EntityLayer;
public class Passenger 
{
    public int PassengerID { get; set; } 
    public string NationalCardNo { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public bool Luggage { get; set; }
    public Gender Gender { get; set; }
    public int TicketID { get; set; }
    public Ticket Ticket { get; set; }
}
public enum Gender
{
    Man = 0,
    Woman = 1
}