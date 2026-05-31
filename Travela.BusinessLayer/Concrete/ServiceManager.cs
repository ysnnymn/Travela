using System.Linq.Expressions;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete;

public class ServiceManager:IServiceService
{
    private readonly IServiceDal _serviceDal;

    public ServiceManager(IServiceDal serviceDal)
    {
        _serviceDal = serviceDal;
    }


    public List<Service> TGetListAll(Expression<Func<Service, bool>> filter = null)
    {
      return _serviceDal.GetListAll(filter);
    }

    public Service TGet(Expression<Func<Service, bool>> filter)
    {
        return _serviceDal.Get(filter);
    }

    public void TAdd(Service entity)
    {
        _serviceDal.Add(entity);
    }

    public void TUpdate(Service entity)
    {
        _serviceDal.Update(entity);
    }

    public void TDelete(Service entity)
    {
        _serviceDal.Delete(entity);
    }
}