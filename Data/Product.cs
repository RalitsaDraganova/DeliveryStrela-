﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryStrela.Data
{
    public class Product
    {
        public int Id { get; set; }

        public int CatalogNumber { get; set; }

        public string Name { get; set; }

        public string Diet { get; set; }

        public double Grams { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Description { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
