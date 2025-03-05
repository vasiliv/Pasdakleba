using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasdakleba.Domain.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public required string NameGeo { get; set; }
        public required string NameEng { get; set; }

        //Navigation properties        
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
