﻿using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)  //aboutmanagere ctrl+. yaptık. generace consructor yaptık.
        {                                        //IAboutDal _aboutDal; bu yapıyı kullanabilmek için.
            _aboutDal = aboutDal;
        }//bu yapı sayesinde atamalarımı kullanabileceğim.


        public List<About> GetList()
        {
            return _aboutDal.GetList();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);

        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}