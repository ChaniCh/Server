using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(int id);

        void Create(T obj);

        void Update(T obj);

        void Delete(int id);
    }
}
