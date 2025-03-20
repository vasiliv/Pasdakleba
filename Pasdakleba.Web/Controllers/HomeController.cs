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
        var currentDate = DateOnly.FromDateTime(DateTime.Today);

        var Sales = _db.Sales
                .Include(u => u.SaleType)
                .Include(u => u.Brand)
                //display only current sales
                .Where(s => s.StartDate <= currentDate && s.EndDate >= currentDate)
                .ToList();
        return View(Sales);        
    }    
}
