using OtBilet.DAL.Abstract;
using OtBilet.DAL.Context;
using OtBilet.DAL.Repository;
using OtBilet.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.EntityFramework;
public class EfAppUserDal : GenericRepository<AppUser>,IAppUserDal
{
    public EfAppUserDal(OtBiletDbContext db) : base(db)
    {
    }
}
