using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserMenager : IUserService
    {
        private IUserDal _userDal;

        public UserMenager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public IResult Add(User user)
        {
            if (user.FirstName.Length>2)
            {
                _userDal.Add(user); 
                return new SuccessResult("Başarılı");
            }
            return new ErrorResult("Islem Gatalı");
           
           
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAllUser()
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }


        public IResult Update(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAllUserById(int id)
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Id == id));
        }
    }
}





