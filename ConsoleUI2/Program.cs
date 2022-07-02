using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI2
{
    class Program
    {
        //Proje Referance -- Bütün katmanları işaretle.
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            //Hangi veri yöntemiyle çalıştığını yazmamız gerekiyor.
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarModelYear);
            }
        }
    }
}
