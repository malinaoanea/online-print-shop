using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintShop.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }

        
        [ForeignKey("ClientUsername")]
        public  { get; set; }

        public IEnumerable<Product> ShoppingCartItems { get; set; }
        
        
    }
}