using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAboutDal : IGenericDal<About> 
    {
        //** İŞTE BU YÖNTEM İŞLERİ UZATACAK OLAN YÖNTEM** AMA BİZ GENERİCTEN MİRAS ALCAZ.
        //void Insert(About p); //About clasından parametre alması için yaptık parantez içini
        //void Delete(About p);
        //void Update(About p);
        //List<About> GetList();
    }
}
