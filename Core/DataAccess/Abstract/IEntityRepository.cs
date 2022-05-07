using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    //<T>; Generic bir tip olarak veriler donecek
    public interface IEntityRepository<T>
    {
        //filtresiz tum listeyi cekmek
        List<T> GetList(Expression<Func<T,bool>> filter=null);

        //filtreli bir veri cekmek icin, id filtresi ile, veri guncelleme icin lazim olur
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
