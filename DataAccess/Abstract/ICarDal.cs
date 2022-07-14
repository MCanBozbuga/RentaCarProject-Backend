using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        /* DataAccess sağ tıkla.Add.Project References. DataAccess, Entities katmanını kullanabilecek. */
        //Başka bir katmanı kullanmak için referans veririz.Data access'de ürünleri listelicez.
        //Ürünler Entities katmanında. Product üzerine gelip, entities referan ekle.
        List<CarDetailDto> GetCarDetails();
    }
}
