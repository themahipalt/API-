﻿// <auto-generated />
using System;
using HandsOnAPIWithEFCore_CodeFirst_Demo1.DBAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HandsOnAPIWithEFCore_CodeFirst_Demo1.Migrations
{
    [DbContext(typeof(HappyDB228Context))]
    [Migration("20220228115416_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchollName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Std")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities.StudentAttendence", b =>
                {
                    b.Property<int>("StudentAttendenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentAttendenceId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAttendences");
                });

            modelBuilder.Entity("HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities.StudentAttendence", b =>
                {
                    b.HasOne("HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}