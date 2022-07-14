using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll(); //filtre vermedik hepsini getirmek için.
        }

        public IEnumerable<object> GetById()
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.GetById(b => b.BrandId == brandId);
        }
    }
}
