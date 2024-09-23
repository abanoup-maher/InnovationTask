using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuForm.Core.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students = new HashSet<Student>();
    }
}
