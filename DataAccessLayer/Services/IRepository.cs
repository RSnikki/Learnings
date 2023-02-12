using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Services
{
    interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        bool Add(T item);
        bool Delete(T item);
        bool Edit(T item);
    }
}
