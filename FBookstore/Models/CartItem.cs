using System.ComponentModel.DataAnnotations;

namespace FBookstore.Models
{
    public class CartItem
    {
        [Key]
        public int ID { get; set; }
        public Cart? Cart { get; set; }
        public int cartId { get; set; }
        public Book? Book { get; set; }
        public int bookId { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
