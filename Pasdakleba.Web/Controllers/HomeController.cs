using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pasdakleba.Infrastructure.Data;
using Pasdakleba.Web.Models;
using Pasdakleba.Web.ViewModels;

namespace Pasdakleba.Web.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _db;
    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        HomeVM homeVM = new()
        {
            SaleList = _db.Sales
                .Include(u => u.SaleType)
                .Include(u => u.Brand)
                .ToList()
        };
        return View(homeVM);
    }    
}
