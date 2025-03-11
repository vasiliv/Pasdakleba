using Microsoft.EntityFrameworkCore;
using Pasdakleba.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasdakleba.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleType> SaleTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>().HasData(
                new Brand {Id = 1, NameEng = "Nikora", NameGeo = "ნიკორა"},
                new Brand {Id = 2, NameEng = "2Nabiji", NameGeo = "2 ნაბიჯი" },
                new Brand {Id = 3, NameEng = "Spar", NameGeo = "სპარი" },
                new Brand {Id = 4, NameEng = "Other", NameGeo = "სხვა" }
                );
            modelBuilder.Entity<SaleType>().HasData(
                new SaleType { Id = 1, NameEng = "Food", NameGeo = "საკვები პროდუქტები" },
                new SaleType { Id = 2, NameEng = "Drinks", NameGeo = "სასმელი" },
                new SaleType { Id = 3, NameEng = "Technique", NameGeo = "ტექნიკა" },
                new SaleType { Id = 4, NameEng = "Shoes And Clothing", NameGeo = "ტანსაცმელი და ფეხსაცმელი" },
                new SaleType { Id = 5, NameEng = "Various", NameGeo = "სხვადასხვა" }
                );            
            modelBuilder.Entity<Sale>().HasData(
                new Sale {Id = 1, BrandId = 1, SaleTypeId = 1,
                            Priority = 1, ImageUrl = "www.pasdakleba.ge/1.jpg",
                            Description = "\U0001f965 ქოქოსი 1ც. - 2.29₾ ნაცვლად 3.50₾-ისა\r\n\U0001f951 ავოკადო 1ც. - 2.69₾ ნაცვლად 3.95₾-ისა\r\n\U0001f96d მანგო 1ც. - 2.99₾ ნაცვლად 4.75₾-ისა\r\n🍊 პომელო 1ც. - 5.49₾ ნაცვლად 8.50₾-ისა",
                            StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2024, 12, 31)
                        }
                );
        }
    }
}
