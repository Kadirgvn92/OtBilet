using OtBilet.DAL.Abstract;
using OtBilet.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.Repository;
public class GenericRepository<T> : IGenericDal<T> where T : class
{
	private readonly OtBiletDbContext _db;

	public GenericRepository(OtBiletDbContext db)
	{
		_db = db;
	}

	public void Add(T t)
	{
		_db.Add(t);
		_db.SaveChanges();
	}

	public void Delete(T t)
	{
		_db.Remove(t);
		_db.SaveChanges();	
	}

	public List<T> GetAll()
	{
		return _db.Set<T>().ToList();
	}

	public T GetByID(int id)
	{
		return _db.Set<T>().Find(id);	
	}

	public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
	{
		return _db.Set<T>().Where(filter).ToList(); //filtremizi listelemek için algoritmamızı yazdık.
	}

	public void Update(T t)
	{
		_db.Update(t);
		_db.SaveChanges();	
	}
}
