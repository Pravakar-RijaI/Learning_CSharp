using System.ComponentModel.DataAnnotations;

namespace ShoppingWebsite.Models
{
    public class Product
    {
        public int? CategoryId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Category? Category { get; set; }

    }
}
