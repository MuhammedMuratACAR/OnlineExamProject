using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Mapping
{
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(I => I.QuestionId);
            builder.Property(I => I.QuestionId).ValueGeneratedOnAdd();
            builder.Property(I => I.QuestionText).HasColumnType("ntext").IsRequired();
            builder.Property(I => I.FirstOption).HasMaxLength(50).IsRequired();
            builder.Property(I => I.SecondOption).HasMaxLength(50).IsRequired();
            builder.Property(I => I.ThirtOption).HasMaxLength(50).IsRequired();
            builder.Property(I => I.FourthOption).HasMaxLength(50).IsRequired();
            builder.Property(I => I.CurrentAnswer).HasMaxLength(50).IsRequired();

        }
    }
}
