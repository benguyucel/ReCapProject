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
    public class EfColour : IColourDal
    {
        public void Add(Colour entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var addedEnttiy = context.Entry(entity);
                addedEnttiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Colour entity)
        {
            using (RentCarContext context  = new RentCarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Colour Get(Expression<Func<Colour, bool>> filter)
        {
            using (RentCarContext context  = new RentCarContext())
            {
                return context.Set<Colour>().SingleOrDefault(filter);
            }
        }

        public List<Colour> GetAll(Expression<Func<Colour, bool>> filter = null)
        {
            using (RentCarContext context =  new RentCarContext())
            {
                var result = filter == null ? context.Set<Colour>().ToList() : context.Set<Colour>().Where(filter).ToList();
                return result;
            }
         
        }

        public void Update(Colour entity)
        {
            using (RentCarContext context  =  new RentCarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
