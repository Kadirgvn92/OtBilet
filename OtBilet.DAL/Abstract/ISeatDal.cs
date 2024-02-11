using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.Abstract;
public interface ISeatDal : IGenericDal<Seat>
{
    public List<Seat> GetSeatsByBusID(int busID);
}
