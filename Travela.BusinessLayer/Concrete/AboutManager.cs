using System.Linq.Expressions;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete;

public class AboutManager:IAboutService
{
    private readonly IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public List<About> TGetListAll(Expression<Func<About, bool>> filter = null)
    {
       return _aboutDal.GetListAll(filter);
    }

    public About TGet(Expression<Func<About, bool>> filter)
    {
        return _aboutDal.Get(filter);
    }

    public void TAdd(About entity)
    {
        _aboutDal.Add(entity);
    }

    public void TUpdate(About entity)
    {
     _aboutDal.Update(entity);
    }

    public void TDelete(About entity)
    {
        _aboutDal.Delete(entity);
    }
}