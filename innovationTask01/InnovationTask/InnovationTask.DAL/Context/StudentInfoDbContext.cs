using InnovationTask.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationTask.DAL.Context
{
    public class StudentInfoDbContext:DbContext
    {
        public StudentInfoDbContext(DbContextOptions<StudentInfoDbContext>options):base(options) 
        {

        }

        DbSet<Student> students {  get; set; }
        DbSet<Subject> subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData
            (
                new Subject { Id = 1, Name = "Arabic" },
                new Subject { Id = 2, Name = "English" },
                new Subject { Id = 3, Name = "Science" },
                new Subject { Id = 4, Name = "Math" },
                new Subject { Id = 5, Name = "History" }
            );
               

            
        }



    }
}
