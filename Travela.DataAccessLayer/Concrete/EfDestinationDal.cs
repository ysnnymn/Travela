using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Concrete;

public class EfDestinationDal:GenericRepository<Destination,TravelaContext>,IDestinationDal
{
    public EfDestinationDal(TravelaContext context):base(context)
    {
        
    }
}