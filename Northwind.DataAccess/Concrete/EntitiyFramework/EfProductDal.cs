using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Products> GetAll() 
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.ToList();
            }
        }
        public Products Get(int id)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.SingleOrDefault(p=>p.Id==id);
            }
        }
        public void Add(Products products) 
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
        }
        public void Update(Products product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        /*
        public void Update(Products product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }*/
        public void Delete(Products product)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
