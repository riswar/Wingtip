using System;
using System.Collections.Generic;

#nullable disable

namespace Wingtip.Domain
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Username { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double? UnitPrice { get; set; }

        public virtual Order Order { get; set; }
    }
}
