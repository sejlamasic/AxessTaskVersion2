using System.Collections.Generic;

namespace AxessTask2.Services
{
    public interface IService<T1, T2> where T1 : class
    {
        IEnumerable<T1> GetAll();
        T1 GetById(T2 id);
        T1 Insert(T1 entity);
        void Delete(T2 id);
        T1 Update(T2 id, T1 entity);
    }
}
