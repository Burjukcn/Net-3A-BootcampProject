﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityTypeConfiguration
{

    public class ApplicantConfiguration : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {

            builder.ToTable("Applicants");
            builder.Property(x => x.About).HasColumnName("About");
            builder.HasMany(p => p.Applications);
            builder.HasOne(p => p.Blacklist);

        }
    }
}