﻿// <auto-generated />
using System;
using IubShop.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IubShop.Migrations
{
    [DbContext(typeof(IubShopContext))]
    [Migration("20190909194836_Newsletter")]
    partial class Newsletter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IubShop.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birth");

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("RegisteDate");

                    b.Property<DateTime>("Updatedate");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("IubShop.Models.Newsletter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.HasKey("Id");

                    b.ToTable("Newsletter");
                });
#pragma warning restore 612, 618
        }
    }
}
