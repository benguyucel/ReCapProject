using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarMenager : ICarService
    {
        private ICarDal _carDal;

        public CarMenager(ICarDal carDal)
        {
          
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (CarValidationMenager.CheckCharacterLength(car.Name)==true && CarValidationMenager.CheckPrice(car.DailyPrice)==true)
            {
                _carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Araba Eklenemedi");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
          return  _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(c => c.ColorId == ColorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
