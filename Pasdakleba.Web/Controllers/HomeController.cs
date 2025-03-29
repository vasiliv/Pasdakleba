using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pasdakleba.Infrastructure.Data;
using Pasdakleba.Web.ViewModels;

namespace Pasdakleba.Web.Controllers;

public class HomeController(ApplicationDbContext db) : Controller
{
    public IActionResult Index(string category)
    {
        var currentDate = DateOnly.FromDateTime(DateTime.Today);

        var sales = db.Sales
            .Include(u => u.SaleType)
            .Include(u => u.Brand)
            .Where(s => s.StartDate <= currentDate && s.EndDate >= currentDate)
            .OrderByDescending(s => s.StartDate) // Show newer sales first
            .ToList();

        if (!string.IsNullOrEmpty(category))
        {
            sales = sales.Where(b => b.SaleType.Url == category).ToList();
        }

        IndexHomeVM indexHomeVM = new()
        {
            Sales = sales,
            Brands = [.. db.Brands
                        .Select(b => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                        {
                            Value = b.Id.ToString(),
                            Text = b.NameGeo
                        })],
            SelectedBrandId = null // No brand selected initially
        };

        return View(indexHomeVM);
    }

    [HttpPost]
    public IActionResult Index(IndexHomeVM model)
    {
        var currentDate = DateOnly.FromDateTime(DateTime.Today);

        var sales = db.Sales
            .Include(u => u.SaleType)
            .Include(u => u.Brand)
            //.Where(s => s.StartDate <= currentDate && s.EndDate >= currentDate)
            .ToList();

        if (model.SelectedBrandId.HasValue)
        {
            sales = sales.Where(s => s.BrandId == model.SelectedBrandId.Value).ToList();
        }

        model.Sales = sales;
        model.Brands = [.. db.Brands
                        .Select(b => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                        {
                            Value = b.Id.ToString(),
                            Text = b.NameGeo,
                            Selected = (model.SelectedBrandId.HasValue && b.Id == model.SelectedBrandId.Value)
                        })];

        return View(model);
    }
    public IActionResult Contact()
    {
        return View("Contact"); // Looks for Views/Shared/contact.cshtml
    }
}
