using Business.Concrete;
using Core.Utilities.Helpers;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarListMethod();
            //AddNewUser();
            //CustomerAddMethod();
            //CarMenager carMenager = new CarMenager(new EfCarDal());
            //carMenager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 0, Description = "asdasd", ModelYear = "2001", Name = "Evo" });

        }

        private static void CustomerAddMethod()
        {
           /* CustomerMenager customerMenager = new CustomerMenager(new EfCustomerDal());
            customerMenager.Add(new Customer { UserId = 1, CompanyName = "Canedom" });
            customerMenager.Add(new Customer { UserId = 2, CompanyName = "Iceranis" });
            customerMenager.Add(new Customer { UserId = 3, CompanyName = "Ventozone" });
            customerMenager.Add(new Customer { UserId = 4, CompanyName = "U-house" });
            customerMenager.Add(new Customer { UserId = 5, CompanyName = "Bigfind" });
            customerMenager.Add(new Customer { UserId = 6, CompanyName = "Funcode" });
            customerMenager.Add(new Customer { UserId = 7, CompanyName = "Zoohow" });
            customerMenager.Add(new Customer { UserId = 8, CompanyName = "Fintrax" });
            customerMenager.Add(new Customer { UserId = 9, CompanyName = "Goodfind" });
            customerMenager.Add(new Customer { UserId = 10, CompanyName = "Moko" });
            customerMenager.Add(new Customer { UserId = 11, CompanyName = "Geotonlux" });
            customerMenager.Add(new Customer { UserId = 12, CompanyName = "Spanware" });
            customerMenager.Add(new Customer { UserId = 13, CompanyName = "Vivafix" });
            customerMenager.Add(new Customer { UserId = 14, CompanyName = "Anquadtaxon" });
            customerMenager.Add(new Customer { UserId = 15, CompanyName = "Quadlam" });
           */
        }

        private static void AddNewUser()
        {
            UserMenager userMenager = new UserMenager(new EfUserDal());
            userMenager.Add(new User { FirstName = "Anthony", LastName = "Fitzgerald", Email = "AnthonyVFitzgerald@armyspy.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Tony", LastName = "Frank", Email = "AnthonyVFitzgerald@armyspy.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Chad", LastName = "Leblanc", Email = "TonyKFrank@teleworm.us", Password = "123456" });
            userMenager.Add(new User { FirstName = "Beverly", LastName = "Bradberry", Email = "BeverlyDBradberry@jourrapide.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Richard", LastName = "Gabbard", Email = "RichardLGabbard@teleworm.us", Password = "123456" });
            userMenager.Add(new User { FirstName = "Patrick", LastName = "McInturff", Email = "PatrickMMcInturff@armyspy.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Mary", LastName = "Cloutier", Email = "MaryDCloutier@teleworm.us", Password = "123456" });
            userMenager.Add(new User { FirstName = "Ana", LastName = "Gamble", Email = "AnaFGamble@jourrapide.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Glenda", LastName = "Heier", Email = "GlendaDHeier@rhyta.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Tammie", LastName = "Pierce", Email = "TammiePPierce@jourrapide.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Howard", LastName = "Brown", Email = "HowardJBrown@armyspy.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Andy", LastName = "Dexter", Email = "AndyCDexter@armyspy.com", Password = "123456" });
            userMenager.Add(new User { FirstName = "Verna", LastName = "Murtagh", Email = "VernaVMurtagh@dayrep.com", Password = "123456" });
        }

        private static void CarListMethod()
        {
            CarMenager carMenager = new CarMenager(new EfCarDal());
            foreach (var carDetail in carMenager.GetCarDetails().Data)
            {
                Console.WriteLine("CarID : {0} Car :{1},{2} Colour : {3} DailyPrice : {4} ", carDetail.CarId, carDetail.BrandName, carDetail.Name, carDetail.ColourName, carDetail.DailyPrice);

            }
        }
    }
}
