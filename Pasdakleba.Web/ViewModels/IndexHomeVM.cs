using Pasdakleba.Domain.Entities;

namespace Pasdakleba.Web.ViewModels
{
    public class IndexHomeVM
    {
        public IEnumerable<Sale> Sales { get; set; }
        public Brand Brand { get; set; }
    }
}
