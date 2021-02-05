using DataAccess.Concrete.EntityFramework.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarDetailService
    {
        List<CarDetailDto> GetCarDetails();
    }
}
