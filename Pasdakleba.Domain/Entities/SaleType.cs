using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasdakleba.Domain.Entities
{
    public class SaleType
    {
        public int Id { get; set; }        
        public required string NameGeo { get; set; }        
        public required string NameEng { get; set; }
        public required string Url { get; set; }

        //Navigation properties        
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
