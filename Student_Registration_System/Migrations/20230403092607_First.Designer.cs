﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_Registration_System.Models;

#nullable disable

namespace Student_Registration_System.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20230403092607_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Student_Registration_System.Models.Course", b =>
                {
                    b.Property<string>("CourseName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseName");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Student_Registration_System.Models.Hobbies", b =>
                {
                    b.Property<string>("HobbiesName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HobbiesName");

                    b.ToTable("Hobby");
                });

            modelBuilder.Entity("Student_Registration_System.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HobbiesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentID");

                    b.HasIndex("CourseName");

                    b.HasIndex("HobbiesName");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student_Registration_System.Models.Student", b =>
                {
                    b.HasOne("Student_Registration_System.Models.Course", "Courses")
                        .WithMany()
                        .HasForeignKey("CourseName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Student_Registration_System.Models.Hobbies", "Hobbie")
                        .WithMany()
                        .HasForeignKey("HobbiesName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Hobbie");
                });
#pragma warning restore 612, 618
        }
    }
}
