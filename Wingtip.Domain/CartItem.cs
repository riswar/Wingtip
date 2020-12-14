using System;
using System.Collections.Generic;

#nullable disable

namespace Wingtip.Domain
{
    public partial class CartItem
    {
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
