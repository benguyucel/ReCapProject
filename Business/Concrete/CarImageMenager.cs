using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageMenager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageMenager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

     

        private IResult CheckIfCarCountOfImageCorrect(int carId)
        {
            List<CarImage> carImages = _carImageDal.GetAll(c=>c.CarID==carId);
            if (carImages.Count>=5)
            {
                return new ErrorResult(Messages.ImageCountOfCarError);
            }
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var result = _carImageDal.Get(x => x.Id == carImage.Id);
            FileHelper.DeleteFile(result.ImagePath);

            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());

        }


        public IResult Update(IFormFile formFile,CarImage carImage)
        {
          var result = _carImageDal.Get(x => x.Id == carImage.Id);
            string name = FileHelper.UpdateFile(formFile, result.ImagePath);
            carImage.ImagePath = name;
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarCountOfImageCorrect(carImage.CarID));
            if (result != null)
            {
                return new ErrorResult(Messages.ImageCountOfCarError);
            }
            else
            {
                string name = FileHelper.UploadFile(formFile);
                carImage.ImagePath = name;
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);
                return new SuccessResult(carImage.ImagePath);
            }
            
        }
    }
}
