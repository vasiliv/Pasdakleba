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
            //Because of public Brand Brand { get; set; } and public SaleType SaleType { get; set; }
            //if (ModelState.IsValid)
            //{
            _db.Sales.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "The sale has been created successfully.";
            return RedirectToAction("Index");
            //}
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
            TempData["success"] = "The sale has been updated successfully.";
            return RedirectToAction("Index");
            //}
            //return View(obj);
        }
        public IActionResult Delete(int SaleId)
        {
            Sale? obj = _db.Sales.FirstOrDefault(u => u.Id == SaleId);
            if (obj is null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(Sale obj)
        {
            Sale? objFromDb = _db.Sales.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                _db.Sales.Remove(objFromDb);
                _db.SaveChanges();
                TempData["success"] = "The sale has been deleted successfully.";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}


