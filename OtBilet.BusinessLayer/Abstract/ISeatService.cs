using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Abstract;
public interface ISeatService : IGenericService<Seat>
{
    public List<Seat> TGetSeatsByBusID(int busID);
}
