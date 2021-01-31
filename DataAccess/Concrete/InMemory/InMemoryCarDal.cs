using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> Cars;
        public InMemoryCarDal()
        {
            Cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=750,Description="Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.",ModelYear=2020},
            new Car{Id=2,BrandId=2,ColorId=4,DailyPrice=150,Description="Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.",ModelYear=2002},
            new Car{Id=3,BrandId=4,ColorId=5,DailyPrice=150,Description="Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.",ModelYear=2004},
            new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=600,Description="Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.",ModelYear=2001},
            new Car{Id=5,BrandId=5,ColorId=1,DailyPrice=500,Description="Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.",ModelYear=2019}

            };
        }
        public void Add(Car car)
        {
            Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car dataToBeDeleted = Cars.FirstOrDefault(x=>x.Id==car.Id);
            Cars.Remove(dataToBeDeleted);

        }

        public List<Car> GetAll()
        {
            return Cars;
        }

        public List<Car> GetById(int CarId)
        {
            return Cars.Where(x => x.Id == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car dataToBeUpdated = Cars.FirstOrDefault(x => x.Id == car.Id);
            dataToBeUpdated.ColorId = car.ColorId;
            dataToBeUpdated.BrandId = car.BrandId;
            dataToBeUpdated.DailyPrice = car.DailyPrice;
            dataToBeUpdated.Description = car.Description;
            dataToBeUpdated.ModelYear = car.ModelYear;
        }
    }
}
