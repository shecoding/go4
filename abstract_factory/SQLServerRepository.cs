using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class SQLServerRepository<T> : IRepository<T>
    {
        public void Add(T obj) { }

        public void Update(T obj) { }

        public void Delete(Guid id) { }

        public T Get(Guid id) {
            throw new NotImplementedException();
        }

        public IList<T> GetList() {
            throw new NotImplementedException();
        }
    }
}