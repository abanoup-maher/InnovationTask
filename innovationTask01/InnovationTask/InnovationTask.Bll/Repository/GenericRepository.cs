using InnovationTask.Bll.Interface;
using InnovationTask.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationTask.Bll.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly StudentInfoDbContext _context;
        private readonly DbSet<T> _Dbset;

        public GenericRepository(StudentInfoDbContext context)
        {
            _context = context;
            _Dbset=_context.Set<T>();
        }

        public async Task Add(T item)
        =>
             await _Dbset.AddAsync(item);

        public async Task<IEnumerable<T>> GetAll() 
            => await _Dbset.ToListAsync();

        public async Task<T> GetById(int id)
        =>
            await _Dbset.FindAsync(id);
    }
}
