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
            ////////////////////car Detail Menager////////////
            CarDetailMenager  carDetailMenager = new CarDetailMenager(new EfCarDetailDto());
            foreach (var carDetail in carDetailMenager.GetCarDetails())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}$", carDetail.Brand, carDetail.Name, carDetail.Color ,carDetail.ModelYear,carDetail.DailyPrice);
            }
            
        }
    }
}
