using System;
using System.Linq;
using NpgsqlTypes;
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
                Restock(t);
                _printShopContext.CartItems.Remove(t);
            }
        }

        private void Restock(CartItem t)
        {
            var product = _printShopContext.Products.Where(p => p.Id.ToString() == t.ProductId).ToList()[0];

            try
            {
                product.Number -= 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't find the product to be bought.");
                throw;
            }
        }

        public void ClearShoppingCart(ShoppingCart shoppingCart)
        {
            _printShopContext.ShoppingCarts.Remove(shoppingCart);
            _printShopContext.SaveChanges();
        }
    }
}