using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic constrait
    //class: referans tip olabilir demek
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı demek
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
