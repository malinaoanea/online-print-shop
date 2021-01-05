using System;
using System.ComponentModel.DataAnnotations;

namespace PrintShop.Models
{
    public class Order
    {
        [Key]
        public string OrderId;
        public string ClientId;
        public string ShoppingCartId;
        public ShoppingCart ShoppingCart;
        public DateTime OrderDate;
        public string DeliveryAddresId;
        public DeliveryAddress DeliveryAddress;

        public Order(string shoppingCartId, ShoppingCart shoppingCart, DeliveryAddress deliveryAddress,  string deliveryAddresId, string clientId, string orderId)
        { 
            ShoppingCart = shoppingCart;
            ShoppingCartId = shoppingCartId;
            OrderDate = DateTime.Now;
            DeliveryAddress = deliveryAddress;
            DeliveryAddresId = deliveryAddresId;
            ClientId = clientId;
            OrderId = orderId;

        }

    }
}