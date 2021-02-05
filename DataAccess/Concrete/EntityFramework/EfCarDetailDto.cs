using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDetailDto : ICarDetailDal
    {


        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto { Id = c.Id,Brand=b.Name,Color=cl.Name,Name=c.Name,DailyPrice=c.DailyPrice,ModelYear=c.ModelYear };
                return result.ToList();
            }
        }
    }
}
