using OtBilet.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DTOLayer.PassangerDTO;
public class ResultPassangerDTO
{
    public int PassengerID { get; set; }
    public string NationalCardNo { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public bool Luggage { get; set; }
    public Gender Gender { get; set; }
    public int TicketID { get; set; }
}