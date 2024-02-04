using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Abstract;
using OtBilet.EntityLayer;

namespace OtBilet.BusinessLayer.Concrete;
public class BusManager : IBusService
{
	private readonly IBusDal _busDal;
	public void TAdd(Bus entity)
	{
		_busDal.Add(entity);
	}

	public void TDelete(Bus entity)
	{
		_busDal.Delete(entity);
	}

	public List<Bus> TGetAll()
	{
		return _busDal.GetAll();
	}

	public Bus TGetByID(int id)
	{
		return _busDal.GetByID(id);
	}

	public void TUpdate(Bus entity)
	{
		_busDal.Update(entity);
	}
}
