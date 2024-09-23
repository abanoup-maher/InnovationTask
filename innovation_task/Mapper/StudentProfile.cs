using AutoMapper;
using innovation_task.Models;
using StuForm.Core.Entities;

namespace innovation_task.Mapper
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentViewModel, Student>().ReverseMap();
        }
    }
}
