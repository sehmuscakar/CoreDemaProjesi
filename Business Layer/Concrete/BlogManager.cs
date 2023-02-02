using Business_Layer.Abstract;
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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;// consratırı buna göre oluştur ,bunu yaz sonra contractırı oluştur 


        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

      

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog>GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id); 
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
    }
}

