
using Entities;
using ShoppingDb;


var products = ProductDb.Products;

foreach (var item in products)
{
    Console.WriteLine($"{item.ProductName,-10}" +
        $"{item.Price,-10}" +
        $"{item.Category.CategoryName,-10}");
}

var myCart = new Cart();

myCart.Add(
    new CartItem()
    {
        Product = ProductDb.Products[0],
        Quantity = 2
    }
);

myCart.Add(
    new CartItem()
    {
        Quantity = 2,
    }
);