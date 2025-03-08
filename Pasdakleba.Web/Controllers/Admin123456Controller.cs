using Microsoft.AspNetCore.Mvc;
using Pasdakleba.Domain.Entities;
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
        [HttpPost]
        public IActionResult Create(Sale obj)
        {
            if (ModelState.IsValid)
            {
                _db.Sales.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Update(int SaleId)
        {
            Sale? obj = _db.Sales.FirstOrDefault(u => u.Id == SaleId);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(Sale obj)
        {
            //Because Brand is invalid
            //if (ModelState.IsValid && obj.Id > 0)
            //{
                _db.Sales.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            //}
            //return View(obj);
        }
    }
}


