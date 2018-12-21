using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Globalization;

namespace ProductsAndCategories
{
    public class MainController : Controller
    {
        // <---------- Dependency inject for dbContext ---------->

        // sets a dBContext field
        private ProductCategoryContext dbContext;

        // Creates dbContext each time the controller is accessed
        public MainController(ProductCategoryContext context)
        {
            dbContext = context;
        }

        // <---------- View routes below ---------->

        // main route, displays Products
        [HttpGet("")]
        public IActionResult Index()
        {
            var productCategoryBundle = new ProductCategoryBundle();
            productCategoryBundle.ProductsList = dbContext.Products.ToList();
            return View("Products", productCategoryBundle);
        }

        // displays Categories
        [HttpGet("categories")]
        public IActionResult Categories()
        {
            var productCategoryBundle = new ProductCategoryBundle();
            productCategoryBundle.CategoriesList = dbContext.Categories.ToList();
            return View("Categories", productCategoryBundle);
        }

        // displays individual product
        [HttpGet("product/{id}")]
        public IActionResult ShowProduct(int id)
        {
            var productCategoryBundle = new ProductCategoryBundle();

            // Sets the product and current categories
            productCategoryBundle.Product = dbContext.Products
                .Include(p => p.Associations)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == id);

            // Sets the product's not linked categories
            productCategoryBundle.CategoriesList = dbContext.Categories
                .Include(c => c.Associations)
                .Where(c => c.Associations.All(a => a.ProductId != id))
                .ToList();

            return View("Product", productCategoryBundle);
        }

        // displays individual category
        [HttpGet("category/{id}")]
        public IActionResult ShowCategory(int id)
        {
            var productCategoryBundle = new ProductCategoryBundle();

            // Sets the product and current categories
            productCategoryBundle.Category = dbContext.Categories
                .Include(c => c.Associations)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(c => c.CategoryId == id);

            // Sets the product's not linked categories
            productCategoryBundle.ProductsList = dbContext.Products
                .Include(p => p.Associations)
                .Where(p => p.Associations.All(a => a.CategoryId != id))
                .ToList();

            return View("Category", productCategoryBundle);
        }

        // <---------- Database creation routes below ---------->

        // Creates a new product
        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product product)
        {
            // Checks model validators. If valid, queries the VB and adds the new product.
            if(ModelState.IsValid)
            {
                // Sets timestamp for product creation
                product.CreatedAt = DateTime.Now;
                product.UpdatedAt = DateTime.Now;

                dbContext.Add(product);
                dbContext.SaveChanges();
                return RedirectToAction("DisplayProduct");
            }

            // else, the error messages are returned.
            else
            {
                // creates the bunled model again for display if the data is invalid
                var productCategoryBundle = new ProductCategoryBundle();
                productCategoryBundle.ProductsList = dbContext.Products.ToList();
                return View("Products", productCategoryBundle);
            }
        }

        // Creates a new category
        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category category)
        {
            // Checks model validators. If valid, queries the VB and adds the new category.
            if(ModelState.IsValid)
            {
                // Sets timestamp for category creation
                category.CreatedAt = DateTime.Now;
                category.UpdatedAt = DateTime.Now;

                // Add Category to DB
                dbContext.Add(category);
                dbContext.SaveChanges();
                return RedirectToAction("DisplayCategory");
            }
            // else, the error messages are returned.
            else
            {
                // creates the bunled model again for display if the data is invalid
                var productCategoryBundle = new ProductCategoryBundle();
                productCategoryBundle.CategoriesList = dbContext.Categories.ToList();
                return View("Categories", productCategoryBundle);
            }
        }

        // <---------- Database linking routes below ---------->

        // Links a Category to a Product
        [HttpPost("CategoryLink")]
        public IActionResult CategoryLink(Association association)
        {
            dbContext.Associations.Add(association);
            dbContext.SaveChanges();
            return RedirectToAction("ShowProduct", new{id = association.ProductId});
        }

        // Links a Product to a Category
        [HttpPost("ProductLink")]
        public IActionResult ProductLink(Association association)
        {
            dbContext.Associations.Add(association);
            dbContext.SaveChanges();
            return RedirectToAction("ShowCategory", new{id = association.CategoryId});
        }
    }
}