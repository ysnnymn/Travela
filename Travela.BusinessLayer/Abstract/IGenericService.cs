using System.Linq.Expressions;
using Travela.EntityLayer.Abstract;

namespace Travela.BusinessLayer.Abstract;

public interface IGenericService<T> where T : class,IEntity, new()
{
    List<T> TGetListAll(Expression<Func<T,bool>> filter = null);
    T TGet(Expression<Func<T, bool>> filter);
    void TAdd(T entity);
    void TUpdate(T entity);
    void TDelete(T entity);
}