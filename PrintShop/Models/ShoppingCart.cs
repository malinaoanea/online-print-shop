using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintShop.Models
{
    public class ShoppingCart
    {
        [Key]
        public string Id { get; set; }
        
        [Required]
        public string ClientId { get; set; }

        public ShoppingCart( string clientId, string id)
        {
            ClientId = clientId;
            Id = id;
        }
        
        
    }
}