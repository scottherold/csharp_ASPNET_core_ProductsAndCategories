using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    // This object represents the many-to-many table in SQL. The 'Product' and 'Category' are public
    // properites that can be accessed by the Product and Category class to create lists of the
    // respective object types.
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }

    }
}