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
                            NameEng = "Nikora",
                            NameGeo = "ნიკორა"
                        },
                        new
                        {
                            Id = 2,
                            NameEng = "2Nabiji",
                            NameGeo = "2 ნაბიჯი"
                        },
                        new
                        {
                            Id = 3,
                            NameEng = "Spar",
                            NameGeo = "სპარი"
                        },
                        new
                        {
                            Id = 4,
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Description = "🥥 ქოქოსი 1ც. - 2.29₾ ნაცვლად 3.50₾-ისა\r\n🥑 ავოკადო 1ც. - 2.69₾ ნაცვლად 3.95₾-ისა\r\n🥭 მანგო 1ც. - 2.99₾ ნაცვლად 4.75₾-ისა\r\n🍊 პომელო 1ც. - 5.49₾ ნაცვლად 8.50₾-ისა",
                            EndDate = new DateOnly(2024, 12, 31),
                            ImageUrl = "www.pasdakleba.ge/1.jpg",
                            Priority = 1,
                            SaleTypeId = 1,
                            StartDate = new DateOnly(2024, 3, 1)
                        });
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

                    b.HasKey("Id");

                    b.ToTable("SaleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameEng = "Food",
                            NameGeo = "საკვები პროდუქტები"
                        },
                        new
                        {
                            Id = 2,
                            NameEng = "Drinks",
                            NameGeo = "სასმელი"
                        },
                        new
                        {
                            Id = 3,
                            NameEng = "Technique",
                            NameGeo = "ტექნიკა"
                        },
                        new
                        {
                            Id = 4,
                            NameEng = "Shoes And Clothing",
                            NameGeo = "ტანსაცმელი და ფეხსაცმელი"
                        },
                        new
                        {
                            Id = 5,
                            NameEng = "Various",
                            NameGeo = "სხვადასხვა"
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
