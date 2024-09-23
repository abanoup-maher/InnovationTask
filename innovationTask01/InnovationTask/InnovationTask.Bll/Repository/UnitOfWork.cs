using InnovationTask.Bll.Interface;
using InnovationTask.DAL.Context;
using InnovationTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationTask.Bll.Repository
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly StudentInfoDbContext _context;
        public  IGenericRepository<Student> StuRepo {  get;}
        public IGenericRepository<Subject> SubjectRepo {  get;}



        public UnitOfWork(StudentInfoDbContext context)
        {
            _context = context;
            StuRepo = new GenericRepository<Student>(context);
            SubjectRepo = new GenericRepository<Subject>(context);
        }
       

        public async Task save()
        =>
            await _context.SaveChangesAsync();

    }
}
