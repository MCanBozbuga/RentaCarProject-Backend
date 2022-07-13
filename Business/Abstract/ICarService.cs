using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //GetCarsByBrandId ve GetCarsByColorId  bunları ICarService'nin içerisine yazdık çünkü arabaları getir diyoruz . Cars tablosunun içerisinde çekicez verileri.
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id); 
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
    }
}
