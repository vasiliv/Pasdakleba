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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>().HasData(
                new Brand {Id = 1, NameEng = "Nikora", NameGeo = "ნიკორა"},
                new Brand {Id = 2, NameEng = "2Nabiji", NameGeo = "2 ნაბიჯი" },
                new Brand {Id = 3, NameEng = "Spar", NameGeo = "სპარი" }
                );
        }
    }
}
