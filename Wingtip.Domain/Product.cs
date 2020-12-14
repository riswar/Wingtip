using System;
using System.Collections.Generic;

#nullable disable

namespace Wingtip.Domain
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double? UnitPrice { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
