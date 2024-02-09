using Microsoft.EntityFrameworkCore;
using OtBilet.DAL.Abstract;
using OtBilet.DAL.Context;
using OtBilet.DAL.Repository;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.EntityFramework;
public class EfTicketDal : GenericRepository<Ticket>, ITicketDal
{

    public EfTicketDal(OtBiletDbContext db) : base(db)
    {

    }

    public Ticket GetTicketByDestinationID(int id)
    {
        using var context = new OtBiletDbContext();
        var values = context.Tickets.Where(x => x.DestinationID == id).Include(y => y.Destination).FirstOrDefault();
        return values;
    }
}
