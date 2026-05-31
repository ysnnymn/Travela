using System.Diagnostics;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Concrete;

public class EfServiceDal:GenericRepository<Service,TravelaContext>,IServiceDal
{
    public EfServiceDal(TravelaContext context) : base(context)
    {
    }
}