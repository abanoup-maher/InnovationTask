using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationTask.Bll.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T item);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
