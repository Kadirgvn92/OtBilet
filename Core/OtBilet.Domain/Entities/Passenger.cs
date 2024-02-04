using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OtBilet.Domain.Entities;
public class Passenger 
{
    public string PassengerID { get; set; } = Guid.NewGuid().ToString();
    public string NationalCardNo { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public bool Luggage { get; set; }
    public Gender Gender { get; set; }
    public string TicketID { get; set; }
    public Ticket Ticket { get; set; }
}
public enum Gender
{
    Man = 0,
    Woman = 1
}