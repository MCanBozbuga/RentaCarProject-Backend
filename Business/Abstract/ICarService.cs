using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //GetCarsByBrandId ve GetCarsByColorId  bunları ICarService'nin içerisine yazdık çünkü arabaları getir diyoruz . Cars tablosunun içerisinde çekicez verileri.
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
        List<Car> GetCarsByBrandId(int id); 
        List<Car> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();
        void Add(Car car);
    }
}
