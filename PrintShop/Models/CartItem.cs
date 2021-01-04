using System.ComponentModel.DataAnnotations;

namespace PrintShop.Models
{
    public class CartItem
    {
        [Key]
        public string CartItemId { get; set; }

        public string CartId { get; set; }

        public string ClientId { get; set; }

        public System.DateTime DateCreated { get; set; }

        public string ProductId { get; set; }

        public virtual Product Product { get; set; }

        public CartItem(string cartId, string clientId, string productId, string cartItemId)
        {
            CartId = cartId;
            ClientId = clientId;
            ProductId = productId;
            CartItemId = cartItemId;
        }
    }
}