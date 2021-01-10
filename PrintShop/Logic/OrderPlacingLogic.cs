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
            
            FreeShoppingBag();
            
            _printShopContext.Orders.Add(new Order(_shoppingCartId, _clientId, deliveryAddresId));
            _printShopContext.SaveChanges();
            
            ClearShoppingCart(shoppingCart);
        }

        public void FreeShoppingBag()
        {
            var itemsToBeRemoved = _printShopContext.CartItems.Where(i => i.CartId == _shoppingCartId).ToList();

            foreach (var t in itemsToBeRemoved)
            {
                _printShopContext.CartItems.Remove(t);
            }
        }

        public void ClearShoppingCart(ShoppingCart shoppingCart)
        {
            _printShopContext.ShoppingCarts.Remove(shoppingCart);
            _printShopContext.SaveChanges();
        }
    }
}