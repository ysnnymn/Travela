using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.BusinessLayer.Abstract;
using Travela.BusinessLayer.Results.Abstract;
using Travela.BusinessLayer.Results.Concrete;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public Category TGetById(int id)
        {
           return _categoryDal.GetById(x=>x.CategoryId==id);
        }

        public int TGetCategoryCount()
        {
            return _categoryDal.GetCategoryCount();
        }

        public List<Category> TGetListAll()
        {
           return _categoryDal.GetListAll();
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
            
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
