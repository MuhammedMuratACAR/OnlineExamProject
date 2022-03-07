using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Mapping
{
    public class ExamMap : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(I => I.ExamId);
            builder.Property(I => I.ExamId).ValueGeneratedOnAdd();
            builder.Property(I => I.ExamTitle).HasMaxLength(150).IsRequired();
            builder.Property(I => I.ExamDescription).HasColumnType("ntext").IsRequired();
            builder.Property(I => I.PostTime).HasDefaultValue(DateTime.Now);
            builder.HasMany(I => I.Questions).WithOne(I => I.Exam).HasForeignKey(I => I.ExamId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
