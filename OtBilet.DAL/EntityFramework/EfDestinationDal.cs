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
public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
{
	public EfDestinationDal(OtBiletDbContext db) : base(db)
	{
		
	}
    public List<Destination> GetDestinationsByFilter(Destination destination)
    {
        using var context = new OtBiletDbContext();
        var values = context.Destinations.Where(x => x.Arrive == destination.Arrive && x.Departure == destination.Departure && x.DepatureDate == destination.DepatureDate).Include(y => y.Bus).ToList();
        return values;
    }
}
