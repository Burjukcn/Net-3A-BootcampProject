﻿// <auto-generated />
using System;
using DataAccess.Concretes.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concretes.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicantId")
                        .HasColumnType("int")
                        .HasColumnName("ApplicantId");

                    b.Property<int>("ApplicationStateId")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationStateId");

                    b.Property<int>("BootcampId")
                        .HasColumnType("int")
                        .HasColumnName("BootcampId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("ApplicationStateId");

                    b.HasIndex("BootcampId");

                    b.ToTable("Applications", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.ApplicationState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ApplicationStates", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Bootcamp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BootcampStateId")
                        .HasColumnType("int")
                        .HasColumnName("BootcampStateId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("InstructorId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("BootcampStateId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Bootcamps", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.BootcampState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("BootcampStates", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NationalIdentity");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Entities.Concretes.Applicant", b =>
                {
                    b.HasBaseType("Entities.Concretes.User");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("About");

                    b.ToTable("Applicants", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Employee", b =>
                {
                    b.HasBaseType("Entities.Concretes.User");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Instructor", b =>
                {
                    b.HasBaseType("Entities.Concretes.User");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Application", b =>
                {
                    b.HasOne("Entities.Concretes.Applicant", "Applicant")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concretes.ApplicationState", "ApplicationState")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicationStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concretes.Bootcamp", "Bootcamp")
                        .WithMany("Applications")
                        .HasForeignKey("BootcampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("ApplicationState");

                    b.Navigation("Bootcamp");
                });

            modelBuilder.Entity("Entities.Concretes.Bootcamp", b =>
                {
                    b.HasOne("Entities.Concretes.BootcampState", "BootcampState")
                        .WithMany("Bootcamps")
                        .HasForeignKey("BootcampStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concretes.Instructor", "Instructor")
                        .WithMany("Bootcamps")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BootcampState");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Entities.Concretes.Applicant", b =>
                {
                    b.HasOne("Entities.Concretes.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concretes.Applicant", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concretes.Employee", b =>
                {
                    b.HasOne("Entities.Concretes.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concretes.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concretes.Instructor", b =>
                {
                    b.HasOne("Entities.Concretes.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concretes.Instructor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concretes.ApplicationState", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Entities.Concretes.Bootcamp", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Entities.Concretes.BootcampState", b =>
                {
                    b.Navigation("Bootcamps");
                });

            modelBuilder.Entity("Entities.Concretes.Applicant", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Entities.Concretes.Instructor", b =>
                {
                    b.Navigation("Bootcamps");
                });
#pragma warning restore 612, 618
        }
    }
}
