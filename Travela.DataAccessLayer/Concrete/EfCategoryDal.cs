using Microsoft.EntityFrameworkCore;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Concrete;

public class EfCategoryDal:GenericRepository<Category,TravelaContext>,ICategoryDal
{
    public EfCategoryDal( TravelaContext context) : base(context)
    {
        
    }
}