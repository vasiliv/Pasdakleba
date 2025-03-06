using Microsoft.AspNetCore.Mvc;
using Pasdakleba.Infrastructure.Data;

namespace Pasdakleba.Web.Controllers
{
    public class Admin123456Controller : Controller
    {
        private readonly ApplicationDbContext _db;
        public Admin123456Controller(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Sales = _db.Sales.ToList();
            return View(Sales);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
