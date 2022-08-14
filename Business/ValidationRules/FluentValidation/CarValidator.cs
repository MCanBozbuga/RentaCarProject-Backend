using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car> //fluent validator'den geliyor
    {
        public CarValidator()   //Kurallar buraya yazılır.
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.CarModelYear).GreaterThanOrEqualTo(2000).When(c => c.CarId == 10);
            #region Kendin şart oluştur. //StartWitA => ctor uygula.
            RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Araba Adı 'A' Harfi İle Başlamalı...");
            #endregion
        }

        private bool StartWithA(string arg)  //arg => CarName
        {
            return arg.StartsWith("A");  //True/false döner.
        }
    }
}
