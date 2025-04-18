using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Pasdakleba.Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int? Priority { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }
        public string Description { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateOnly StartDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateOnly EndDate { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;


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
