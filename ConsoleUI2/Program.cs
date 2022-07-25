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
            CarTest();
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName + brand.BrandId);
                
            //}
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName + color.ColorId);
            //}
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarDescription + car.CarId);
            //}
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Car Name : " +car.CarName +" Brand Name : "+car.BrandName+" Color Name : "+car.ColorName+" Daily Price : "+car.DailyPrice );
            //}
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Hangi veri yöntemiyle çalıştığını yazmamız gerekiyor.
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " " + car.ColorName);
                }
            }
            Console.WriteLine(result.Message);
        }
    }
}
