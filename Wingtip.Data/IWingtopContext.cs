using Microsoft.EntityFrameworkCore;
using Wingtip.Domain;

namespace Wingtip.Data
{
    public interface IWingtopContext
    {
        DbSet<CartItem> CartItems { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
    }
}