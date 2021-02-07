using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarMenager carMenager = new CarMenager(new EfCarDal());
            foreach (var carDetail in carMenager.GetCarDetails())
            {
                Console.WriteLine("CarID : {0} Car :{1},{2} Colour : {3} DailyPrice : {4} ",carDetail.CarId,carDetail.BrandName,carDetail.Name,carDetail.ColourName,carDetail.DailyPrice);

            }
            
        }
    }
}
