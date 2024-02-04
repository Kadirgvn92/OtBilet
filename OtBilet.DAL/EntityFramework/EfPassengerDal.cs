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
public class EfPassengerDal : GenericRepository<Passenger>,IPassengerDal
{
	public EfPassengerDal(OtBiletDbContext db) : base(db)
	{
	}
}
