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

    public Ticket CreateTicketByDestinationID(int id)
    {
        using var context = new OtBiletDbContext();
        var destination = context.Destinations.Where(x => x.DestinationID == id).FirstOrDefault();

        Ticket ticket = new Ticket()
        {
            DestinationID = destination.DestinationID,
            SeatID = 1,
            PNR = PNRGenerator.GeneratePNR()

        };
        context.Tickets.Add(ticket);
        context.SaveChanges();

        var values = context.Tickets.Where(x => x.DestinationID == id).Include(y => y.Destination).Include(z => z.Seat).FirstOrDefault();
        return values;
    }

}
