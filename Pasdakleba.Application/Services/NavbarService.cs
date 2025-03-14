using Microsoft.EntityFrameworkCore;
using Pasdakleba.Application.Interfaces;
using Pasdakleba.Domain.Entities;
using Pasdakleba.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasdakleba.Application.Services
{
    public class NavbarService : INavbarService
    {
        private readonly ApplicationDbContext _db;

        public NavbarService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<SaleType>> GetNavbarItemsAsync()
        {
            return await _db.SaleTypes.ToListAsync();
        }
    }
}
