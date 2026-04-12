using System.Linq.Expressions;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete;

public class CategoryManager:ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> TGetListAll(Expression<Func<Category, bool>> filter = null)
    {
        return _categoryDal.GetListAll(filter);
    }

    public Category TGet(Expression<Func<Category, bool>> filter)
    {
        return _categoryDal.Get(filter);
    }

    public void TAdd(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public void TDelete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public int TGetCategoryCount()
    {
      return  _categoryDal.GetCategoryCount();
    }
}