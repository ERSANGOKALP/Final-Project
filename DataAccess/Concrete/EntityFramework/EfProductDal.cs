using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        void Add(Product entity)
        {
            using (NortWindContext context=new NortWindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        void IEntityRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        void Delete(Product entity)
        {
            using (NortWindContext context = new NortWindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        void IEntityRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        List<Product> IEntityRepository<Product>.GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

        Product Get(Expression<Func<Product, bool>> filter)
        {
        using (NortWindContext context= new NortWindContext())
        {
            return context.Set<Product>().SingleOrDefault(filter);
        }
        }

        List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
        using (NortWindContext context=new NortWindContext())
        {
            return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
        }
        }

        void Update(Product entity)
        {
        using (NortWindContext context = new NortWindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
    
}
