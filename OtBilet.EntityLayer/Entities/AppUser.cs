using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.EntityLayer.Entities;
public class AppUser : IdentityUser<int>
{
    public string NationalCardNo { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public string Mail { get; set; }
    public bool Luggage { get; set; }
    public Gender Gender { get; set; }
    public List<Ticket> Ticket { get; set; }
}
public enum Gender
{
    Man = 0,
    Woman = 1
}