using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcers.Validation
{
    public static class ValidationTool  //baske yerde kullanmayacağımız için static yapabiliriz.
    {
        public static void  Validate(IValidator validator, object entity)  //1. ihtiyac İnterface bul. , Hepsinin base, object.
        {
            var context = new ValidationContext<object>(entity);          
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
        #region Eski Hali
        /*
        public static Validate(IValidator validator)  //1. ihtiyac İnterface bul.
        {
            var context = new ValidationContext<Car>(car);
            /*CarValidator carValidator = new CarValidator();*/ //buna ihtiyac kalmadı.
        //    var result = carValidator.Validate(context);
        //    if (!result.IsValid)
        //    {
        //        throw new ValidationException(result.Errors);
        //    }
        //}
        #endregion
    }
}
