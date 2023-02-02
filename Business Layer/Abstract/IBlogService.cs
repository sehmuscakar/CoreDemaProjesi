using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Abstract
{
     public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetList();

        Blog GetById(int id);

        List<Blog> GetBlogListWithCategory();//listeyle beraber category getir 


    }
}
