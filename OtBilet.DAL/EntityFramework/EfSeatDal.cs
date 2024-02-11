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
public class EfSeatDal : GenericRepository<Seat>, ISeatDal
{
	public EfSeatDal(OtBiletDbContext db) : base(db)
	{
	}
	public List<Seat> GetSeatsByBusID(int busID)
	{
		using var context = new OtBiletDbContext();
		var values = context.Seats.Where(x => x.BusID == busID).ToList();
		return values;
	}
}
