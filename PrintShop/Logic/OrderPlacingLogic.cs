using System.Linq;
using PrintShop.Models;

namespace PrintShop.Logic
{
    public class OrderPlacingLogic
    {
        public string _shoppingCartId;

        private PrintShopContext _printShopContext;
        private string _clientId;

        public OrderPlacingLogic(PrintShopContext printShopContext, string clientId, string shoppingCartId)
        {
            _printShopContext = printShopContext;
            _clientId = clientId;
            _shoppingCartId = shoppingCartId;
        }

        public void UseThisAddress(string deliveryAddresId)
        {
            var shoppingCart = _printShopContext.ShoppingCarts.Where(s => s.Id == _shoppingCartId).ToList()[0];

            var deliveryAddress = _printShopContext.DeliveryAddresses.Where(d => d.Id == deliveryAddresId).ToList()[0];
            //var orderId = (_printShopContext.Order1s.Count() + 1).ToString();
            _printShopContext.Orders.Add(new Order(_shoppingCartId, _clientId, deliveryAddresId));
            _printShopContext.SaveChanges();
        }
    }
}