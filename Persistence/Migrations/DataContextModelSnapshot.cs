﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Domain.Entity.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Domain.Entity.JobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationRef")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationSource")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobPostURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Domain.Entity.JobApplicationProgress", b =>
                {
                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProgressNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ProgressDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgressType")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationId", "ProgressNo");

                    b.ToTable("Progresses");
                });

            modelBuilder.Entity("Domain.Entity.JobApplication", b =>
                {
                    b.HasOne("Domain.Entity.Company", "Company")
                        .WithMany("applications")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Domain.Entity.JobApplicationProgress", b =>
                {
                    b.HasOne("Domain.Entity.JobApplication", "Application")
                        .WithMany("progress")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Domain.Entity.Company", b =>
                {
                    b.Navigation("applications");
                });

            modelBuilder.Entity("Domain.Entity.JobApplication", b =>
                {
                    b.Navigation("progress");
                });
#pragma warning restore 612, 618
        }
    }
}
