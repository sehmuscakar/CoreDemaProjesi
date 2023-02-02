using EntityLayer.concrete;//bu eklendi 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
namespace DataAccessLayer.Abstract
{
  public  interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory(); // ilgili entitye ait bir yapı kulandığımızda kulanırız bu yuntemi 
        //Bloglara Özel olduğu için burda tanımladık 
        //category ile braber listeyi getir diye anlamı var 

    }
}
