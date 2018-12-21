using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Category
    {
        // Sets product key for SQL
        [Key]
        public int CategoryId { get; set; }

        [Display(Name="Category Name")]
        // Errors for Name
        [Required(ErrorMessage="Category name is required!")]
        [MinLength(2,ErrorMessage="Category name must be at least two characters long!")]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Ties the model to the Association Model for many-to-many relationship.
        public List<Association> Associations { get; set; }

    }
}