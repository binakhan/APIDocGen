﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIWebHelp.Models;

namespace APIWebHelp.Controllers
{
    /// <summary>
    /// All operations related to Product
    /// </summary>
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        //[System.Obsolete]
        /// <summary>
        /// Gets all Products in the system.
        /// </summary>
        /// <returns>Returns Product collection.</returns>
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


        /// <summary>
        /// Get Product corresponding to the provided ID.
        /// </summary>
        /// <param name="id">ID of the Product to be fetched.</param>
        /// <returns></returns>
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// Inserts the given Product in collection.
        /// </summary>
        /// <param name="Product">Product to be added.</param>
        /// <returns>Returns the message indicating addition response.</returns>
        [HttpPost]
        public string AddProduct(Product Product)
        {
            products[products.Length - 1] = Product;
            return "Product added successfully";
        }
    }
}
