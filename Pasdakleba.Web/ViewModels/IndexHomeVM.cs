using Microsoft.AspNetCore.Mvc.Rendering;
using Pasdakleba.Domain.Entities;

namespace Pasdakleba.Web.ViewModels;

public class IndexHomeVM
{
    public List<Sale> Sales { get; set; }
    public List<SelectListItem> Brands { get; set; }  // List of brands for dropdown
    public int? SelectedBrandId { get; set; }  // Selected Brand ID
}
