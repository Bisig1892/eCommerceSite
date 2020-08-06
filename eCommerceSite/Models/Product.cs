using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    /// <summary>
    /// A salable product
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        /// <summary>
        /// The consumer facing name of the product
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The retail price as US currency
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Category the product falls under. EX. Electronics, Furniture, etc.
        /// </summary>
        public string Category { get; set; }
    }
}
