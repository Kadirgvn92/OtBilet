using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Abstract;
public interface IDestinationService : IGenericService<Destination>
{
    public List<Destination> TGetDestinationsByFilter(SearchDestinationDTO destination);
}
