using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FBookstore.Models
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        [DisplayName("Category")]
        public string categoryName { get; set; }
    }
}