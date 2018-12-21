using System;
using System.Collections.Generic;

namespace ProductsAndCategories.Models
{
    public class ProductCategoryBundle
    {
        // Accessors for the product/category model
        public Product Product { get; set; }
        public Category Category { get; set; }

        // Attached lists for product/category models
        // Use for all, linked and unlinked depending on the situation.
        public List<Product> ProductsList { get; set; }
        public List<Category> CategoriesList { get; set; }

    }
}