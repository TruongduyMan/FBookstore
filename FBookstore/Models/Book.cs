using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FBookstore.Models
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        [Required]
        [DisplayName("Book Name")]
        public string bookTitle { get; set; }

        public Category? Category { get; set; }
        [DisplayName("Category")]
        public int catId { get; set; }
        [DisplayName("Image")]
        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
