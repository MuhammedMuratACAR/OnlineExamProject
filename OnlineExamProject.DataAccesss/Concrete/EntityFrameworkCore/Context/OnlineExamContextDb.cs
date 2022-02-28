using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Mapping;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Context
{

    public class OnlineExamContextDb : IdentityDbContext<AppUser, AppRole, int>
    {
        //public OnlineExamContextt(DbContextOptions<OnlineExamContextt> options)
        //: base(options)
        //{ }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source =C:\Users\acarm\source\repos\OnlineExamProject\OnlineExamProject.DataAccesss\OnlineExam.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new ExamMap());
            modelBuilder.ApplyConfiguration(new QuestionMap());

            base.OnModelCreating(modelBuilder);
        }


    }
}
