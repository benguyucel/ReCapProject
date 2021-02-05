using DataAccess.Concrete.EntityFramework.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDetailDal
    {
        List<CarDetailDto> GetCarDetails();
    }
}
