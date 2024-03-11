﻿using Core.Utilities.Security.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityTypeConfiguration
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.ToTable("OperationClaims").HasKey(t => t.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.Name).HasColumnName("Name");

            builder.HasMany(t => t.UserOperationClaims);

        }
    }

   }
