using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Abstract;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Concrete;
public class SeatManager : ISeatService
{
	private readonly ISeatDal _seatDal;

	public SeatManager(ISeatDal seratDal)
	{
		_seatDal = seratDal;
	}

	public void TAdd(Seat entity)
	{
		_seatDal.Add(entity);
	}

	public void TDelete(Seat entity)
	{
		_seatDal.Delete(entity);	
	}

	public List<Seat> TGetAll()
	{
		return _seatDal.GetAll();
	}

	public Seat TGetByID(int id)
	{
		return _seatDal.GetByID(id);
	}

    public List<Seat> TGetSeatsByBusID(int busID)
    {
		return _seatDal.GetSeatsByBusID(busID);
    }

    public void TUpdate(Seat entity)
	{
		_seatDal.Update	(entity);
	}
}
