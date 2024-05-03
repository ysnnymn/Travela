using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.BusinessLayer.Results.Abstract;
using Travela.EntityLayer.Abstract;

namespace Travela.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class,IEntity,new()
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        T TGetById(int id);
        List<T> TGetListAll();
    }
}
