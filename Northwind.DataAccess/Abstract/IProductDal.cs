using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Products> GetAll();
        Products Get(int id);
        void Add(Products products);
        void Update(Products product);
        void Delete(Products product);
    }
}
