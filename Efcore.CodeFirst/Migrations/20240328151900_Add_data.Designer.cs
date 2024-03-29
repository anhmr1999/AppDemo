﻿// <auto-generated />
using System;
using Efcore.CodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Efcore.CodeFirst.Migrations
{
    [DbContext(typeof(CodeFirstDbContext))]
    [Migration("20240328151900_Add_data")]
    partial class Add_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Efcore.CodeFirst.Product", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_key");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Key"), 1L, 1);

                    b.Property<Guid?>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("product_id");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit")
                        .HasColumnName("product_available");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("product_name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("product_price");

                    b.HasKey("Key");

                    b.ToTable("table_product", (string)null);

                    b.HasData(
                        new
                        {
                            Key = 1,
                            IsAvailable = false,
                            Name = "Product 1",
                            Price = 10m
                        },
                        new
                        {
                            Key = 2,
                            Id = new Guid("1ac61a6b-da50-4e40-9a90-8041eb24ebb9"),
                            IsAvailable = false,
                            Name = "Pro max",
                            Price = 100m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
