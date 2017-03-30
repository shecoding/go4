using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public interface IRepository<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        T Get(Guid id);

        IList<T> GetList();
    }
}