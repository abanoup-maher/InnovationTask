using InnovationTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationTask.Bll.Interface
{
    public interface IUnitOfWork
    {
        IGenericRepository<Student> StuRepo { get; }
        IGenericRepository<Subject> SubjectRepo {  get; }
        Task save();
    }
}
