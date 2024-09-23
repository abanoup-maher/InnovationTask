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
    public class SubjectRepo : GenericRepo<Subject> , Isubject
    {
        public SubjectRepo(InnovationDbContext Dbcotext) : base(Dbcotext)
        {
        }

        public Task<int> Add(Isubject item)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(Isubject item)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Isubject item)
        {
            throw new NotImplementedException();
        }

        Task<Isubject> IGenericRepo<Isubject>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Isubject>> IGenericRepo<Isubject>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
