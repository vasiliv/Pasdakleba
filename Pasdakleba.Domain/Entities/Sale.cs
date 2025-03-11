using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Pasdakleba.Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int? Priority { get; set; }        
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        //Navigation properties
        public int BrandId { get; set; }
        //Modelstate.IsValid will not work without it
        [ValidateNever]
        public Brand Brand { get; set; }

        public int SaleTypeId { get; set; }
        //Modelstate.IsValid will not work without it
        [ValidateNever]
        public SaleType SaleType { get; set; }
    }
}
