using Microsoft.EntityFrameworkCore;
using StuForm.BLL.Interfaces;
using StuForm.Core.Context;
using StuForm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuForm.BLL.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly InnovationDbContext _dbcontext;

        public GenericRepo(InnovationDbContext Dbcotext)
        {
            _dbcontext = Dbcotext;
        }

      

        public async Task<int> Add(T item)
        {
           _dbcontext.Set<T>().Add(item);
            return await _dbcontext.SaveChangesAsync();  
        }

       

        public async Task<int> Delete(T item)
        {
            _dbcontext.Set<T>().Remove(item);
            return await _dbcontext.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        =>
            await _dbcontext.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Student))
            {
                return (IEnumerable<T>)await _dbcontext.Set<Student>().Include(e => e.StudentSubjects).ToListAsync();
            }
            return await _dbcontext.Set<T>().ToListAsync();
        }
    }
}
