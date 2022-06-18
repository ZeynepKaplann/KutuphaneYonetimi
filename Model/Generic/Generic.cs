using KutuphaneYonetimSistemi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.Model.Generic
{
    public class Generic<T> where T : class,new()
    {
        KutuphaneYonetimiEntities db = new KutuphaneYonetimiEntities();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Add(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void Delete( T p )
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();

        }
        public void Update ( T p)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>>kosul)
        {
            return db.Set<T>().FirstOrDefault(kosul);
        }

       

    }
}
