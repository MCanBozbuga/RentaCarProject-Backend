using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //İş sınıfı, diğer iş sınıfları new'lemez. Bunun yerine _
        ICarDal _carDal;
        //Ctor uygula.
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

       

        public void Add(Car Car)
        {
            if (Car.CarName.Length < 2 && Car.CarDailyPrice > 0)
            {
                _carDal.Add(Car);
            }
            else
            {
                Console.WriteLine("Girdiğiniz veriler uygun değildir.\n Fiyat 0'dan büyük, Min. karakter 2'den fazla olmalıdır.");
            }
        }

        public List<Car> GetAll()
        {
            // İş Kodlarını yaz
            //Yetkisi var mı, if ... , şartlardan geçerse ürünleri ver.
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.GetById(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        //public List<Car> GetCarsByBrandId(int id)
        //{
        //    return _carDal.GetAll(c => c.CarBrandId == id);
        //}

        //public List<Car> GetCarsByColorId(int id)
        //{
        //    return _carDal.GetAll(c => c.CarColorId == id);
        //}
    }
}
