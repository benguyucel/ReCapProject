﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<List<Customer>> GetAllCustomer();
        IDataResult<List<Customer>> GetAllCustomerById(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    }
}
