﻿// <auto-generated />
using MasaBomby.BazaDanych.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MasaBomby.BazaDanych.Migrations
{
    [DbContext(typeof(ConvertorDbContext))]
    partial class ConvertorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("MasaBomby.BazaDanych.Modele.Jednostki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CharRepresentation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("RodzajeJednostekId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RodzajeJednostekId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("MasaBomby.BazaDanych.Modele.Przelicznik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Multiplier")
                        .HasColumnType("REAL");

                    b.Property<int>("UnitFromId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnitToId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UnitFromId");

                    b.HasIndex("UnitToId");

                    b.ToTable("Convertors");
                });

            modelBuilder.Entity("MasaBomby.BazaDanych.Modele.RodzajeJednostek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypeOfUnits");
                });

            modelBuilder.Entity("MasaBomby.BazaDanych.Modele.Jednostki", b =>
                {
                    b.HasOne("MasaBomby.BazaDanych.Modele.RodzajeJednostek", "RodzajeJednostek")
                        .WithMany("Units")
                        .HasForeignKey("RodzajeJednostekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RodzajeJednostek");
                });

            modelBuilder.Entity("MasaBomby.BazaDanych.Modele.Przelicznik", b =>
                {
                    b.HasOne("MasaBomby.BazaDanych.Modele.Jednostki", "UnitFrom")
                        .WithMany()
                        .HasForeignKey("UnitFromId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasaBomby.BazaDanych.Modele.Jednostki", "UnitTo")
                        .WithMany()
                        .HasForeignKey("UnitToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitFrom");

                    b.Navigation("UnitTo");
                });

            modelBuilder.Entity("MasaBomby.BazaDanych.Modele.RodzajeJednostek", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
