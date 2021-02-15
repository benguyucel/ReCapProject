using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentCarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCutomerDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {

                var result = from c in context.Customers
                        join u in context.Users
                        on c.Id equals u.Id
                        select new CustomerDetailDto
                        {
                            Id=c.Id,
                            FirstName=u.FirstName,
                            LastName=u.LastName,
                            CompanyName=c.CompanyName,
                        };
                return result.ToList();
            }
        }
    }
}
