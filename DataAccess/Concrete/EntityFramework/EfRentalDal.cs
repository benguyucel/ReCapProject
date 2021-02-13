using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
       
        public Rental GetRentInfo(Rental rental)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return context.Rentals.FirstOrDefault(r => r.CarId == rental.CarId);
            }    
        }
    }
}
