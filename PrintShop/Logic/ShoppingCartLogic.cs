using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using PrintShop.Models;


namespace PrintShop.Logic
{
    public class ShoppingCartLogic
    {
        public string ShoppingCartId { get; set; }

        private PrintShopContext _printShopContext;
        private string _clientId;


        
        public ShoppingCartLogic(PrintShopContext _printShopContext, string clientId)
        {
          this._printShopContext = _printShopContext;
          _clientId = clientId;
        }

        public void AddToCart(string id)
        {
            // Retrieve the product from the database.           
            ShoppingCartId = GetCartId();

            if (ShoppingCartId == null)
            {
              // there is no shopping cart for the client
              string cartId = _printShopContext.ShoppingCarts.Count().ToString();
              _printShopContext.ShoppingCarts.Add(new ShoppingCart( _clientId, cartId));
              _printShopContext.SaveChanges();

              ShoppingCartId = GetCartId();
              
              //add the new cart item to the cart
              string cartItemId = _printShopContext.CartItems.Count().ToString();
              _printShopContext.CartItems.Add(new CartItem(ShoppingCartId, _clientId, id));
              _printShopContext.SaveChanges();
            }
            else
            {
              string cartItemId = _printShopContext.CartItems.Count().ToString();
              _printShopContext.CartItems.Add(new CartItem(ShoppingCartId, _clientId, id));
              _printShopContext.SaveChanges();
            }

           
        }

        public void Dispose()
        {
          if (_printShopContext != null)
          {
            _printShopContext.Dispose();
            _printShopContext = null;
          }
        }

        public string GetCartId()
        {
          var x =_printShopContext.ShoppingCarts.Where(c=> c.ClientId == _clientId);
          if (x.Count() == 0)
            return null;
          else
            return x.ToList()[0].Id;
        }

        public List<CartItem> GetCartItems()
        {
          ShoppingCartId = GetCartId();

          return _printShopContext.CartItems.Where(
              c => c.CartId == ShoppingCartId).ToList();
        }

        public void DeleteCartItem(string productId)
        {
          var cartId = GetCartId();
          var toBeRemoved = _printShopContext.CartItems.Where(c => c.ProductId == productId && c.CartId == cartId)
            .ToList()[0];

          _printShopContext.CartItems.Remove(toBeRemoved);
          _printShopContext.SaveChanges();
        }
      }
        
}