﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcers.Caching
{
    interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duraction);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
