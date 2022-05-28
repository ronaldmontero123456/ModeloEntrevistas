using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModeloEntrevistas.Core.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        void Update(T entity);
        Task Delete(int id);
    }
}
