using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        public Product Product { get; set; }

        public uint Quantity { get; set; }

    }
    public class Cart
    {
        private List<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public void Add(CartItem item)
        {
            CartItems.Add(item);
        }

        public void Remove(int id)
        {
            var cartitem = CartItems
                .Where(ci => ci.CartItemId == id)
                .FirstOrDefault();
            CartItems.Remove(cartitem);
        }

        public void ShowCart()
        {
            foreach (var item in CartItems)
            {
                Console.WriteLine($"{item.Product.ProductName,-10}" +
                    $"{item.Quantity,-10}" +
                    $"{item.Product.Price,-10}" +
                    $"{item.Product.Price * item.Quantity,-5}");



            }

        }
    }
}
