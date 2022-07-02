using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;  //veri varmış gibi ürün listesi oluşturduk.Global değişken _ ile veririz.
        // ctor bellekte referans aldığı zaman çalışacak olan blok.
        public InMemoryCarDal()  //Ctor
        {
            _cars = new List<Car> {
             new Car{CarId=1, CarBrandId=2, CarColorId=3, CarDailyPrice=10 , CarDescription="2022 car.", CarModelYear=2022},
             new Car{CarId=2, CarBrandId=3, CarColorId=4, CarDailyPrice=20, CarDescription="2021 car.", CarModelYear=2021},
             new Car{CarId=3, CarBrandId=4, CarColorId=5, CarDailyPrice=30, CarDescription="2020 car.", CarModelYear=2021}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Gönderdiğim ürün idsine sahip olan Listedeki ürünü bul.
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            //Gönderdiğim ürün idsine sahip olan Listedeki ürünü bul.
            Car carToUpdate = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarModelYear = car.CarModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;   //veri tabanını döndür.
        }

        public List<Car> GetById(int carId)
        {
            // Where, içindeki şarta uyan elemanları yeni liste haline getirip onu döndürür.
            return _cars.Where(c=> c.CarId == carId).ToList();
        }


    }
}
