using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        // Sets product key for SQL
        [Key]
        public int ProductId { get; set; }

        [Display(Name="Product Name")]
        // Errors for Name
        [Required(ErrorMessage="Product name is required!")]
        [MinLength(2,ErrorMessage="Product name must be at least two characters long!")]
        public string Name { get; set; }

        [Display(Name="Product Description")]
        // Errors for Description
        [Required(ErrorMessage="Product Description is required!")]
        [MinLength(10,ErrorMessage="Product Description must be at least 10 characters long!")]
        public string Description { get; set; }

        [Display(Name="Product Price")]
        // Errors for Price
        [Required(ErrorMessage="Product Price is required!")]
        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage="Please enter a valid monetary amount!")]
        public double? Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Ties the model to the Association Model for many-to-many relationship.
        public List<Association> Associations { get; set; }
    }
}