using System.Collections.Generic;

namespace Practica3.EF.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();
        void Add(T newLogic);
        void Update(T logic);
        void Delete(int id);
    }
}
