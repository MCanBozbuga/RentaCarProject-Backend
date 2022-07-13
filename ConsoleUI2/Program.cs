using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI2
{
    class Program
    {
        //Proje Referance -- Bütün katmanları işaretle.
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Hangi veri yöntemiyle çalıştığını yazmamız gerekiyor.
            foreach (var car in carManager.GetCarsByBrandId(2))  //BrandId=2 olanları listele
            {

                Console.WriteLine(" Car Name : " +car.CarName + " Model Year : " +car.CarModelYear + "DailyPrice : " +car.CarDailyPrice);
                Console.WriteLine("Brand ID=2 olan " + car.CarColorId);

                               
            }
        }
    }
}
