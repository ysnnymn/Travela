using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Travela.EntityLayer.Abstract;

namespace Travela.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class,IEntity,new()
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(Expression<Func<T,bool>> filter);
        List<T> GetListAll(Expression<Func<T,bool>> filter=null);
    }
}
