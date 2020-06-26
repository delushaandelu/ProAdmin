﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAdminWebVersion.Models;

namespace ProAdminWebVersion.Migrations
{
    [DbContext(typeof(ManageStudentDetailsContext))]
    [Migration("20200626162114_InitCreate")]
    partial class InitCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProAdminWebVersion.Models.StudentsDetail", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlSchool")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Batch")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("HomeAdress")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("HomeTell")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("JoinedDate")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nic")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("OlResult")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("OlSchool")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ParentsTell")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RegId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Scholership")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("StayAddress")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("StayHomeTell")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Sid");

                    b.ToTable("StudentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
