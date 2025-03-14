namespace Pasdakleba.Web.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<SaleVM>? SaleVMs { get; set; }
        public DateOnly? SaleStart { get; set; }
        public DateOnly? SaleFinish { get; set; }
    }
}
