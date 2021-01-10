using System.ComponentModel.DataAnnotations;
using Humanizer;

namespace PrintShop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ShippingCartId { get; set; }
        public string ClientId { get; set; }
        public string DeliveryAddressId { get; set; }
        

        public Order(string shippingCartId, string clientId, string deliveryAddressId)
        {
            // Id = id;
            ShippingCartId = shippingCartId;
            ClientId = clientId;
            DeliveryAddressId = deliveryAddressId;
        }
    }
}