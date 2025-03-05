using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pasdakleba.Infrastructure.Data;
using Pasdakleba.Web.Models;

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
        var Brands = _db.Brands.ToList();
        return View(Brands);
    }    
}
