using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.DAL.Abstract;
public interface IGenericDal<T> where T : class
{
	public void Add(T t);
	public void Update(T t);
	public void Delete(T t);
	T GetByID(int id);
	List<T> GetAll();
	List<T> GetListByFilter(Expression<Func<T, bool>> filter);
}
