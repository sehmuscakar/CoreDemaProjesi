using Business_Layer.Abstract;//bunun eklmesi lazım miras için ilk önce 
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
  public  class CategoryManager : ICategoryService//sonra iplete edilmesi lazım, CategoryManager üzeinde +. yap constractır yap 
    {
        ICategoryDal _categoryDal;//_categoryDal bi fail tanımladık

        

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; //constructor yaptık 
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category); //category den gelen değeri ekle
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
