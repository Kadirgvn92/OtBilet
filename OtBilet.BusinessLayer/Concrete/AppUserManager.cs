using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Abstract;
using OtBilet.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Concrete;
public class AppUserManager : IAppUserService
{
    private readonly IAppUserDal _userDal;

    public AppUserManager(IAppUserDal userDal)
    {
        _userDal = userDal;
    }

    public void TAdd(AppUser entity)
    {
        _userDal.Add(entity);
    }

    public void TDelete(AppUser entity)
    {
        _userDal.Delete(entity);
    }

    public List<AppUser> TGetAll()
    {
        return _userDal.GetAll();
    }

    public AppUser TGetByID(int id)
    {
        return _userDal.GetByID(id);
    }

    public void TUpdate(AppUser entity)
    {
        _userDal.Update(entity);
    }
}
