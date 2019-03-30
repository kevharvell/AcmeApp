﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override string ToString() => ProductName;
        // Validates the product data.
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }


    }
}
