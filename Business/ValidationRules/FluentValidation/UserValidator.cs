using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotNull().EmailAddress();
            RuleFor(u => u.FirstName).NotNull().MinimumLength(3);
            RuleFor(u => u.LastName).NotNull().MinimumLength(3);
            RuleFor(u => u.Password).NotNull().NotEmpty();
        }
    }
}
