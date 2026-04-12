using Microsoft.EntityFrameworkCore;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Concrete;

public class EfCategoryDal:GenericRepository<Category,TravelaContext>,ICategoryDal
{
    private readonly TravelaContext _context;
    public EfCategoryDal( TravelaContext context) : base(context)
    {
        _context = context;
    }

    public int GetCategoryCount()
    {
        
        var value=_context.Categories.Count();
        return value;
    }
}