﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Rental(Rental rental);
        IResult DeleteRental(Rental rental);
        IResult UpdateRental(Rental rental);
        IDataResult<List<Rental>> GetAllRental();
        IDataResult<List<Rental>> GetAllRentalById(int id);
        IDataResult<List<RentalDetailDto>> GetRentalsDetail();
    }
}
