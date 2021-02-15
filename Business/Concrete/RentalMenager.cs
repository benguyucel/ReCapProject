using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalMenager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalMenager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult DeleteRental(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAllRental()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
                
        }

        public IDataResult<List<Rental>> GetAllRentalById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.Id==id));
        }

        public IResult Rental(Rental rental)
        {
            //eğer kiralanan araçların içinde yoksa
            var result =  _rentalDal.Get(r=>r.CarId==rental.CarId);
            if (result==null || result.ReturnDate!=null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Araç Kiralandı");
            }
            else
            {
                return new ErrorResult("Araç zaten kirada");
            }
           
            
        }

        public IResult UpdateRental(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
