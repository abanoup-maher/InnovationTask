using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationTask.DAL.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public string SelectedSubjectIds { get; set; }



    }
}
