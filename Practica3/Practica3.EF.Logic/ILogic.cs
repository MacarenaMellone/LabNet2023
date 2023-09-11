using System.Collections.Generic;

namespace Practica3.EF.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();
        void Add(T dto);
        void Update(T dto);
        bool Delete(int id);
    }
}
