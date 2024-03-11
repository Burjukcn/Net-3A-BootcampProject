using Core.Utilities.Security.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityTypeConfiguration
{

    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.ToTable("UserOperationClaims").HasKey(t => t.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.UserId).HasColumnName("UserId");
            builder.Property(x => x.OperationClaimId).HasColumnName("OperationClaimId");

            builder.HasOne(t => t.User);
            builder.HasOne(t => t.OperationClaim);

        }
    }
}
