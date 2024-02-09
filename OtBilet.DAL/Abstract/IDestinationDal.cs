using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.Abstract;
public interface IDestinationDal : IGenericDal<Destination>
{
    public List<Destination> GetDestinationsByFilter(SearchDestinationDTO destination);
    public Destination GetDestinationByID(int id);

}
