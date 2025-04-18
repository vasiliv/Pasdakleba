﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pasdakleba.Infrastructure.Data;

#nullable disable

namespace Pasdakleba.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pasdakleba.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGeo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameEng = "2Nabiji",
                            NameGeo = "2 ნაბიჯი"
                        },
                        new
                        {
                            Id = 2,
                            NameEng = "Carrefour",
                            NameGeo = "კარფური"
                        },
                        new
                        {
                            Id = 3,
                            NameEng = "Magniti",
                            NameGeo = "მაგნიტი"
                        },
                        new
                        {
                            Id = 4,
                            NameEng = "Nikora",
                            NameGeo = "ნიკორა"
                        },
                        new
                        {
                            Id = 5,
                            NameEng = "Spar",
                            NameGeo = "სპარი"
                        },
                        new
                        {
                            Id = 6,
                            NameEng = "SuptaSakhli",
                            NameGeo = "სუფთა სახლი"
                        },
                        new
                        {
                            Id = 7,
                            NameEng = "Fresco",
                            NameGeo = "ფრესკო"
                        },
                        new
                        {
                            Id = 8,
                            NameEng = "Other",
                            NameGeo = "სხვა"
                        });
                });

            modelBuilder.Entity("Pasdakleba.Domain.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("SaleTypeId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("SaleTypeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Pasdakleba.Domain.Entities.SaleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGeo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SaleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameEng = "Food",
                            NameGeo = "საკვები პროდუქტები",
                            Url = "/food"
                        },
                        new
                        {
                            Id = 2,
                            NameEng = "Drinks",
                            NameGeo = "სასმელი",
                            Url = "/drinks"
                        },
                        new
                        {
                            Id = 3,
                            NameEng = "Technique",
                            NameGeo = "ტექნიკა",
                            Url = "/technique"
                        },
                        new
                        {
                            Id = 4,
                            NameEng = "Shoes And Clothing",
                            NameGeo = "ტანსაცმელი და ფეხსაცმელი",
                            Url = "/shoesandclothing"
                        },
                        new
                        {
                            Id = 5,
                            NameEng = "Parfume And Cleanery",
                            NameGeo = "პარფიუმერია და სისუფთავე",
                            Url = "/parfumeandcleanery"
                        },
                        new
                        {
                            Id = 6,
                            NameEng = "Auto/Moto",
                            NameGeo = "ავტო/მოტო",
                            Url = "/automoto"
                        },
                        new
                        {
                            Id = 7,
                            NameEng = "Various",
                            NameGeo = "სხვადასხვა",
                            Url = "/various"
                        });
                });

            modelBuilder.Entity("Pasdakleba.Domain.Entities.Sale", b =>
                {
                    b.HasOne("Pasdakleba.Domain.Entities.Brand", "Brand")
                        .WithMany("Sales")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pasdakleba.Domain.Entities.SaleType", "SaleType")
                        .WithMany("Sales")
                        .HasForeignKey("SaleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("SaleType");
                });

            modelBuilder.Entity("Pasdakleba.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Pasdakleba.Domain.Entities.SaleType", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
