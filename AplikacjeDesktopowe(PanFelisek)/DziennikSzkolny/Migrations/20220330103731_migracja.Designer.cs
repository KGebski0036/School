// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Szkolny_Dziennik.BazaDanych.Context;

namespace Szkolny_Dziennik.Migrations
{
    [DbContext(typeof(StudentsDataBase))]
    [Migration("20220330103731_migracja")]
    partial class migracja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("Szkolny_Dziennik.BazaDanych.Models.SchoolClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameOfSchoolClass")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SchoolClasses");
                });

            modelBuilder.Entity("Szkolny_Dziennik.BazaDanych.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SchoolClassId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SurName")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SchoolClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Szkolny_Dziennik.BazaDanych.Models.Student", b =>
                {
                    b.HasOne("Szkolny_Dziennik.BazaDanych.Models.SchoolClass", "Schoolclass")
                        .WithMany()
                        .HasForeignKey("SchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schoolclass");
                });
#pragma warning restore 612, 618
        }
    }
}
