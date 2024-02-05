using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Abstract;
using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Concrete;
public class DestinationManager : IDestinationService
{ 
	private readonly IDestinationDal _destinationDal;

	public DestinationManager(IDestinationDal destinationDal)
	{
		_destinationDal = destinationDal;
	}

	public void TAdd(Destination entity)
	{
		_destinationDal.Add(entity);
	}

	public void TDelete(Destination entity)
	{
		_destinationDal.Delete(entity);
	}

	public List<Destination> TGetAll()
	{
		return _destinationDal.GetAll();
	}

	public Destination TGetByID(int id)
	{
		return _destinationDal.GetByID(id);
	}

    public List<Destination> TGetDestinationsByFilter(SearchDestinationDTO destination)
    {
		return _destinationDal.GetDestinationsByFilter(destination);
    }

    public void TUpdate(Destination entity)
	{
		_destinationDal.Update(entity);	
	}
}
