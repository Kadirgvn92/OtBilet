using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Abstract;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Concrete;
public class PassengerManager : IPassengerService
{
	private readonly IPassengerDal _passangerDal;

	public PassengerManager(IPassengerDal passangerDal)
	{
		_passangerDal = passangerDal;
	}

	public void TAdd(Passenger entity)
	{
		_passangerDal.Add(entity);
	}

	public void TDelete(Passenger entity)
	{
		_passangerDal.Delete(entity);
	}

	public List<Passenger> TGetAll()
	{
		return _passangerDal.GetAll();	
	}

	public Passenger TGetByID(int id)
	{
		return _passangerDal.GetByID(id);
	}

	public void TUpdate(Passenger entity)
	{
		_passangerDal.Update(entity);
	}
}
