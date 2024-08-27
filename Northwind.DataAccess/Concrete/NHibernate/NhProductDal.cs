using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {

        public void Add(Products products)
        {
            throw new NotImplementedException();
        }

        public void Delete(Products product)
        {
            throw new NotImplementedException();
        }

        public Products Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            List<Products> product = new List<Products> 
            {
                new Products
                {
                    Id = 1, Marka = "Mercedes", Model = "C200", Yil = 2020, Fiyat = 3000, KullaniciAdi = "orcuncesur",
                    BirakmaTarihi =  DateTime.Now
                }
            };
            return product;
        }

        public void Update(Products product)
        {
            throw new NotImplementedException();
        }
    }
}
