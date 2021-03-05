using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidation:AbstractValidator<CarImage>
    {
        public CarImageValidation()
        {
            RuleFor(x => x.ImagePath).NotEmpty();
            RuleFor(x => x.ImagePath).Must(IsUniqueName);
            
        }

        private bool IsUniqueName(string arg)
        {
            throw new NotImplementedException();
        }
    }
}
