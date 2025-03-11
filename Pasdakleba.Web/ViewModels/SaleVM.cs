using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pasdakleba.Domain.Entities;

namespace Pasdakleba.Web.ViewModels
{
    public class SaleVM
    {
        public Sale? Sale { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> BrandList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> SaleTypeList { get; set; }
    }
}
