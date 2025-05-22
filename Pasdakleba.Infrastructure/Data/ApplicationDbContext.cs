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
                new Brand { Id = 1, NameEng = "2Nabiji", NameGeo = "2 ნაბიჯი" },
                new Brand { Id = 2, NameEng = "Aversi", NameGeo = "ავერსი" },
                new Brand { Id = 3, NameEng = "Carrefour", NameGeo = "კარფური" },
                new Brand { Id = 4, NameEng = "Libre", NameGeo = "ლიბრე" },
                new Brand { Id = 5, NameEng = "Magniti", NameGeo = "მაგნიტი" },
                new Brand { Id = 6, NameEng = "Nikora", NameGeo = "ნიკორა"},               
                new Brand { Id = 7, NameEng = "Spar", NameGeo = "სპარი" },
                new Brand { Id = 8, NameEng = "SuptaSakhli", NameGeo = "სუფთა სახლი" },
                new Brand { Id = 9, NameEng = "Fresco", NameGeo = "ფრესკო" },
                new Brand { Id = 10, NameEng = "Other", NameGeo = "სხვა" },
                new Brand { Id = 11, NameEng = "Gorgia", NameGeo = "გორგია" },
                new Brand { Id = 12, NameEng = "Alta", NameGeo = "ალტა" } ,
                new Brand { Id = 13, NameEng = "Zgapari", NameGeo = "ზღაპარი" },
                new Brand { Id = 14, NameEng = "Super", NameGeo = "სუპერი" },
                new Brand { Id = 15, NameEng = "Elite", NameGeo = "ელიტი" },
                new Brand { Id = 16, NameEng = "Zoomer", NameGeo = "ზუმერი" }
                );
            modelBuilder.Entity<SaleType>().HasData(
                new SaleType { Id = 1, NameEng = "Food", NameGeo = "საკვები პროდუქტები", Url = "/food" },
                new SaleType { Id = 2, NameEng = "Drinks", NameGeo = "სასმელი", Url = "/drinks" },
                new SaleType { Id = 3, NameEng = "Technique", NameGeo = "ტექნიკა", Url = "/technique" },
                new SaleType { Id = 4, NameEng = "Shoes And Clothing", NameGeo = "ტანსაცმელი და ფეხსაცმელი", Url = "/shoesandclothing" },
                new SaleType { Id = 5, NameEng = "Parfume And Cleanery", NameGeo = "პარფიუმერია და სისუფთავე", Url = "/parfumeandcleanery" },
                new SaleType { Id = 6, NameEng = "Auto/Moto", NameGeo = "ავტო/მოტო", Url = "/automoto" },
                new SaleType { Id = 7, NameEng = "Various", NameGeo = "სხვადასხვა", Url = "/various" },
                new SaleType { Id = 8, NameEng = "Toys", NameGeo = "სათამაშოები", Url = "/toys" }
                );            
            modelBuilder.Entity<Sale>().HasData(
                //new Sale {Id = 1, BrandId = 1, SaleTypeId = 1,
                //            Priority = 1, ImageUrl = "www.pasdakleba.ge/1.jpg",
                //            Description = "\U0001f965 ქოქოსი 1ც. - 2.29₾ ნაცვლად 3.50₾-ისა\r\n\U0001f951 ავოკადო 1ც. - 2.69₾ ნაცვლად 3.95₾-ისა\r\n\U0001f96d მანგო 1ც. - 2.99₾ ნაცვლად 4.75₾-ისა\r\n🍊 პომელო 1ც. - 5.49₾ ნაცვლად 8.50₾-ისა",
                //            StartDate = new DateOnly(2024, 3, 1), EndDate = new DateOnly(2024, 12, 31)
                //        }
                );
        }
    }
}
