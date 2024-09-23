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
    public class studentRepo : GenericRepo<Student> ,Istudent
    {
        public studentRepo(InnovationDbContext Dbcotext) : base(Dbcotext)
        {
        }
    }
}
