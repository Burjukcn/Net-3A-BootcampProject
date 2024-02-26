using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityTypeConfiguration
{
    public class BootcampStateConfiguration : IEntityTypeConfiguration<BootcampState>
    {
        public void Configure(EntityTypeBuilder<BootcampState> builder)
        {
            builder.ToTable("BootcampStates").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.Name).HasColumnName("Name");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate");


            builder.HasMany(x => x.Bootcamps);
        }
    }
}