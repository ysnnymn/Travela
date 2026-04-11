using System.Linq.Expressions;
using Travela.EntityLayer.Abstract;

namespace Travela.DataAccessLayer.Abstract;

public interface IGenericDal<T> where T : class, IEntity,new()
{
    List<T> GetListAll(Expression<Func<T,bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    
}