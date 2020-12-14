using System.ComponentModel.DataAnnotations;

namespace Wingtip.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public double? UnitPrice { get; set; }
        public object Description { get; internal set; }
    }
}
