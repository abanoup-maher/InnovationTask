using StuForm.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuForm.BLL.Repositories
{
    public class UnitOfWork : IUnitOFWork
    {
        public Istudent StuRep { get; set; }
        public Isubject subRep { get; set; }
      

        public UnitOfWork(Istudent StuRepo , Isubject subRepo)
        {
            StuRep=StuRepo;
            subRep=subRepo;
        }
    }
}
