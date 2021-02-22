using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ColourValidator:AbstractValidator<Colour>
    {
        public ColourValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(3);
        }
    }
}
