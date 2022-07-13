﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public bool carName;

        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CarBrandId { get; set; }
        public int CarColorId { get; set; }
        public int CarModelYear { get; set; }
        public int CarDailyPrice { get; set; }
        public string CarDescription { get; set; }
    }
}
