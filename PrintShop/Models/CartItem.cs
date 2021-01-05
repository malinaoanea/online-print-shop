using System.ComponentModel.DataAnnotations;

namespace PrintShop.Models
{
    public class CartItem
    {
        public string CartItemId { get; set; }

        public string CartId { get; set; }

        public string ClientId { get; set; }

        public System.DateTime DateCreated { get; set; }

        public string ProductId { get; set; }

        public virtual Product Product { get; set; }
        
        public static int No { get; set; }

        public CartItem(string cartId, string clientId, string productId)
        {
            CartId = cartId;
            ClientId = clientId;
            ProductId = productId;
            CartItemId = ( No + 1).ToString() ;
            No += 1;
        }
    }
}