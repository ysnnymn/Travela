using System.Linq.Expressions;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete;

public class DestinationManager:IDestinationService
{
    private readonly IDestinationDal _destinationDal;

    public DestinationManager(IDestinationDal destinationDal)
    {
        _destinationDal = destinationDal;
    }

    public List<Destination> TGetListAll(Expression<Func<Destination, bool>> filter = null)
    {
return _destinationDal.GetListAll(filter);   
    }

    public Destination TGet(Expression<Func<Destination, bool>> filter)
    {
       return _destinationDal.Get(filter);
    }

    public void TAdd(Destination entity)
    {
       _destinationDal.Add(entity);
    }

    public void TUpdate(Destination entity)
    {
        _destinationDal.Update(entity);
    }

    public void TDelete(Destination entity)
    {
        _destinationDal.Delete(entity);
    }
}