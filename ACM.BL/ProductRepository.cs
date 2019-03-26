using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        // Retrieve one customer.
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 1)
            {
                product.ProductName = "Widget";
                product.ProductDescription = "widgety widgy widget";
                product.CurrentPrice = 32;
            }
            return product;
        }
        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;
        }
    }
}
