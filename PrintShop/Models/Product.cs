using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public float Price { get; set; }
        
        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public int Number { get; set; }

        
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        
    }
}