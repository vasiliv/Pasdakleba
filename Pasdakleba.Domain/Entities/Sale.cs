using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasdakleba.Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation properties
        public ICollection<Brand> Brands { get; set; } = new List<Brand>();
    }
}
