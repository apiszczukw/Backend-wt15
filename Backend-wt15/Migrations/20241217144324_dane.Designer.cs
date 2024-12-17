﻿// <auto-generated />
using System;
using Backend_wt15.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_wt15.Migrations
{
    [DbContext(typeof(SklepContext))]
    [Migration("20241217144324_dane")]
    partial class dane
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend_wt15.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "pomidor",
                            Price = 7.9f,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "ziemniaki",
                            Price = 2.9f,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            Name = "ogorek",
                            Price = 9.9f,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 4,
                            Name = "kalafior",
                            Price = 11.9f,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 5,
                            Name = "brokuł",
                            Price = 7.5f,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 6,
                            Name = "cukinia",
                            Price = 8.2f,
                            Quantity = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
