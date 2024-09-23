using Microsoft.EntityFrameworkCore;
using StuForm.Core.Entities;
using StuForm.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StuForm.Core.Context
{
    public class InnovationDbContext:DbContext
    {
        public InnovationDbContext(DbContextOptions<InnovationDbContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder MB)
        {

            MB.Entity<StudentSubject>()
            .HasKey(ss => new { ss.StudentId, ss.SubjectId });

            MB.Entity<Subject>()
                .HasMany(s => s.Students)
                .WithMany(s => s.StudentSubjects);

            //MB.Entity<StudentSubject>()
            //    .HasOne(ss => ss.Student)
            //    .WithMany(s => s.StudentSubjects)
            //    .HasForeignKey(ss => ss.StudentId);

            //MB.Entity<StudentSubject>()
            //    .HasOne(ss => ss.Subject)
            //    .WithMany(s => s.StudentSubjects)
            //    .HasForeignKey(ss => ss.SubjectId);

        }
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<StudentSubject> StudentSubjects { get; set; }


    }
}
