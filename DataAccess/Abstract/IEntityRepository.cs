using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic constraint -- generic=kısıtlama
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implement eden bir nesne olabilir.
    //new() = new'lenebilir olmalı.   where'den sonrası kısıtlama işlemleri...
    public interface IEntityRepository<T> where T:class,IEntity,new() //generic repository
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //Tüm ürünleri listele.Buradaki ''Car '' farklı bir katmandan gelecek.
                                                                  //Car' üstüne gelip ampülden Entities'den referansla.
        T GetById(Expression<Func<T, bool>> filter =null);
        void Add(T entity);                   
        void Delete(T entity);
        void Update(T entity);
    }
}
