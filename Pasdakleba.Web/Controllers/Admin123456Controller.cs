using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pasdakleba.Domain.Entities;
using Pasdakleba.Infrastructure.Data;
using Pasdakleba.Web.ViewModels;

namespace Pasdakleba.Web.Controllers
{
    public class Admin123456Controller : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Admin123456Controller(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment    )
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var Sales = _db.Sales
                .Include(u => u.SaleType)
                .Include(u => u.Brand)
                .ToList();
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
                if (obj.Sale.Image != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(obj.Sale.Image.FileName);
                    //images folder in wwwroot
                    string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\");

                    using var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                    obj.Sale.Image.CopyTo(fileStream);

                    obj.Sale.ImageUrl = @"\images\" + fileName;
                }
                else
                {
                    obj.Sale.ImageUrl = "https://placehold.co/600x400";
                }
                _db.Sales.Add(obj.Sale);
                _db.SaveChanges();
                TempData["success"] = "The sale has been created successfully.";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Update(int SaleId)
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
                }),
                Sale = _db.Sales.FirstOrDefault(u => u.Id == SaleId)
            };
            if (saleVm == null)
            {
                return NotFound();
            }
            return View(saleVm);
        }
        [HttpPost]
        public IActionResult Update(SaleVM saleVM)
        {
            if (ModelState.IsValid)
            {
                _db.Sales.Update(saleVM.Sale);
                _db.SaveChanges();
                TempData["success"] = "The sale has been updated successfully.";
                return RedirectToAction("Index");
            }
            saleVM.BrandList = _db.Brands.ToList().Select(u => new SelectListItem
            {
                Text = u.NameGeo,
                Value = u.Id.ToString()
            });
            saleVM.SaleTypeList = _db.SaleTypes.ToList().Select(u => new SelectListItem
            {
                Text = u.NameGeo,
                Value = u.Id.ToString()
            });
            return View(saleVM);
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


