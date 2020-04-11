using System;
using System.Collections.Generic;
using XMen.Query;

namespace SMS.Service
{
    public interface IRepository<T>
    {
        T CreateObject();

        T FindBy(Guid id);

        IEnumerable<T> FindAll();

        IEnumerable<T> FindAll(int index, int count);

        IEnumerable<T> FindBy(Query query);

        IEnumerable<T> FindBy(Query query, int index, int count);

        int CountAll();

        int CountBy(Query query);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}