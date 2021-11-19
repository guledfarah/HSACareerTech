using System;
using System.Collections.Generic;
using System.Text;

namespace HSACareerTech.BL
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            return !(string.IsNullOrWhiteSpace(ProductName) || (CurrentPrice == null));
        }

        public void SaveProduct(Product product)
        {

        }

        public Product RetrieveProduct()
        {
            return new Product();
        }

        public Product RetrieveProduct(int id)
        {
            return new Product();
        }
    }
}
