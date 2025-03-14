using Pasdakleba.Domain.Entities;

namespace Pasdakleba.Web.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Sale>? SaleList { get; set; }
        public DateOnly? SaleStart { get; set; }
        public DateOnly? SaleEnd { get; set; }
    }
}
