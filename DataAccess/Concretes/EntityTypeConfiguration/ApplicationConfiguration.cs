using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityTypeConfiguration
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {

            builder.ToTable("Applications").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.ApplicantId).HasColumnName("ApplicantId");
            builder.Property(x => x.BootcampId).HasColumnName("BootcampId");
            builder.Property(x => x.ApplicationStateId).HasColumnName("ApplicationStateId");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate");

            builder.HasOne(x => x.Bootcamp);
            builder.HasOne(x => x.Applicant);
            builder.HasOne(x => x.ApplicationState);

        }



    }
}