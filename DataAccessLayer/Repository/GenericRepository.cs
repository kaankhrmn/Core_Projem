using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context(); //veri tabanıyla etkileşim.
            c.Remove(t);
            c.SaveChanges();//veri tabanına yansıdı
        }

        public T GetById(int id)
        {
            using var c = new Context(); //veri tabanıyla etkileşim.
            return c.Set<T>().Find(id); //id ye göre bulma işlemi yapar.
        }

        public List<T> GetList()
        {
            using var c = new Context(); //veri tabanıyla etkileşim.
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context(); //veri tabanıyla etkileşim.
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context(); //veri tabanıyla etkileşim.
            c.Update(t);
            c.SaveChanges();
        }
    }
}
