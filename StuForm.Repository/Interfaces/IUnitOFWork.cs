using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuForm.BLL.Interfaces
{
    public interface IUnitOFWork
    {
        public Istudent StuRep { get; set; }
        public Isubject subRep { get; set; }
    }
}
