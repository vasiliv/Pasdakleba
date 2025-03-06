﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation properties
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
