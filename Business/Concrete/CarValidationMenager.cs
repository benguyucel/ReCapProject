using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public static class CarValidationMenager
    {
        public static bool CheckCharacterLength(string character)
        {
            return character.Length >= 2 ? true : false;
        }

        public static bool CheckPrice(decimal price)
        {
            return price > 0 ? true : false;
        }
    }
}
