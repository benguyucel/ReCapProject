using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarDetailMenager : ICarDetailService
    {
        ICarDetailDal _carDetail;

        public CarDetailMenager(ICarDetailDal carDetail)
        {
            _carDetail = carDetail;
        }

        public List<CarDetailDto> GetCarDetails()
        {
           return  _carDetail.GetCarDetails();
            
        }
    }
}
