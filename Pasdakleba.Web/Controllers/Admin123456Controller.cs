﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pasdakleba.Domain.Entities;
using Pasdakleba.Infrastructure.Data;
using Pasdakleba.Web.ViewModels;

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
            SaleVM saleVm = new()
            {
                BrandList = _db.Brands.ToList().Select(u => new SelectListItem
                {
                    Text = u.NameGeo,
                    Value = u.Id.ToString()
                }),
                SaleTypeList = _db.SaleTypes.ToList().Select(u => new SelectListItem
                {
                    Text = u.NameGeo,
                    Value = u.Id.ToString()
                })
            };
            return View(saleVm);
        }
        [HttpPost]
        public IActionResult Create(SaleVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Sales.Add(obj.Sale);
            _db.SaveChanges();
            TempData["success"] = "The sale has been created successfully.";
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
            if (ModelState.IsValid && obj.Id > 0)
            {
                _db.Sales.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "The sale has been updated successfully.";
            return RedirectToAction("Index");
            }
            return View(obj);
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


