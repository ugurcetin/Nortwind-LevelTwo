using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>//Dao
    {
        //Repository Pattern
        //Listeleme, ekleme, silme, guncelleme imzalari

    }
}
