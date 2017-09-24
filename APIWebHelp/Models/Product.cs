using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIWebHelp.Models
{
    /// <summary>
    /// Defines a Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// ID of the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category of the product
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        public decimal Price { get; set; }
    }
}