﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal  //Ürüne özel operasyonlar yapacağımız için ICarDal gerekiyor.
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto 
                             {
                                 BrandName =b.BrandName,CarName=c.CarName,
                                 ColorName=co.ColorName,DailyPrice=c.CarDailyPrice 
                             };
                return result.ToList();
            }
        }
    }
}
