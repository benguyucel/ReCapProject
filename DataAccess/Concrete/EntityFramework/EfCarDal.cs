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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarContext rentCarContext =  new RentCarContext())
            {
                var addedEntity = rentCarContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                rentCarContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                var deletedEntity = rentCarContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                rentCarContext.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                return rentCarContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext rentCarContext =  new RentCarContext())
            {
                return filter == null ? rentCarContext.Set<Car>().ToList() : rentCarContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                var updatedEntity = rentCarContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                rentCarContext.SaveChanges();
            }
        }
    }
}
