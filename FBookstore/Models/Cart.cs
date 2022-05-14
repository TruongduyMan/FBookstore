using System.ComponentModel.DataAnnotations;

namespace FBookstore.Models
{
    public class Cart
    {
        [Key]
        public int cartId { get; set; }
        public string userId { get; set; }
    }
}
