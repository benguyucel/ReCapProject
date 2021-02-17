using Business.Abstract;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColourMenager : IColourService
    {
        IColourDal _colurDal;

        public ColourMenager(IColourDal colurDal)
        {
            _colurDal = colurDal;
        }

        public IResult Add(Colour colour)
        {
            _colurDal.Add(colour);
            return new SuccessResult();
        }

        public IResult Delete(Colour colour)
        {
            _colurDal.Delete(colour);
            return new SuccessResult();
        }

        public IDataResult<List<Colour>> GetAllColour()
        {
            return new SuccessDataResult<List<Colour>>(_colurDal.GetAll());
        }

        public IDataResult<Colour> GetColourById(int id)
        {
            return new SuccessDataResult<Colour>(_colurDal.Get(x => x.Id == id));
        }

        public IResult Update(Colour colour)
        {
            _colurDal.Update(colour);
            return new SuccessResult();
        }
    }
}
