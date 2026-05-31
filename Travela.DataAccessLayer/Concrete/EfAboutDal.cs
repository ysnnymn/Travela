using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Concrete;

public class EfAboutDal:GenericRepository<About,TravelaContext>,IAboutDal
{
    public EfAboutDal(TravelaContext context) : base(context)
    {
    }
}