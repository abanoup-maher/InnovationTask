using StuForm.Core.Entities;
using System.Collections.Generic;
using System;

namespace innovation_task.Models
{
    public class StudentViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Subject> StudentSubjects = new HashSet<Subject>();

        public ICollection<Subject> Subjects { get; set; }
        public List<int> SelectedSubjects { get; set; }
    }
}
