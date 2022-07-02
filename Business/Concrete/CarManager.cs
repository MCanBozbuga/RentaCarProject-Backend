using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetAll()
        {
            // İş Kodlarını yaz
            //Yetkisi var mı, if ... , şartlardan geçerse ürünleri ver.
            return _carDal.GetAll();
        }
    }
}
