using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarMenager carMenager = new CarMenager(new InMemoryCarDal());
            carMenager.Add(new Car { 
                Id = 6, 
                BrandId = 4,
                ColorId = 2, 
                DailyPrice = 600,
                Description = "Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.", ModelYear = 2019 });
           
            foreach (var item in carMenager.GetAll())
            {
                Console.WriteLine(item.Id);
            }
            
        }
    }
}
