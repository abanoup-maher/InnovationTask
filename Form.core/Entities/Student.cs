using StuForm.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuForm.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
     
        public string Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Subject> StudentSubjects = new HashSet<Subject>();
    }
}
