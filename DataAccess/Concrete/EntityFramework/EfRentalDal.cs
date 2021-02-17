using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CarId equals c.Id
                             join cr in context.Cars
                             on r.CarId equals cr.Id
                             join cl in context.Colors
                             on cr.ColorId equals cl.Id
                             join b in context.Brands
                             on cr.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 BrandName = b.Name,
                                 CarName=cr.Name,
                                 ColorName=cl.Name,
                                 CustomerName=c.CompanyName,
                                 ModelYear=cr.ModelYear,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                             };
                return result.ToList();
            }
        }

    }
}
