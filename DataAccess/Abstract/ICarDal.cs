using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        //Başka bir katmanı kullanmak için referans veririz.Data access'de ürünleri listelicez.
        //Ürünler Entities katmanında. Product üzerine gelip, entities referan ekle.
        List<Car> GetAll();  //Tüm ürünleri listele.Buradaki ''Car '' farklı bir katmandan gelecek.
                             //Car' üstüne gelip ampülden Entities'den referansla.
        List<Car> GetById(int carId);
        void Add(Car car);                    //Parametre olarak Car aldırdık.Add(Car car)
        void Delete(Car car);
        void Update(Car car);
    }
}
