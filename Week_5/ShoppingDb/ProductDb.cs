using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ShoppingDb
{
    public static class ProductDb
    {
        public static List<Product> Products { get; set; }
        static ProductDb()
        {
            Products = new List<Product>()
            {
                new Product(){
                    ProductId=1,
                    ProductName="Hp",
                    Price=15000,
                    Category= new Category() { CategoryId=1,CategoryName="Electronic"}
                },
                new Product(){
                    ProductId=2,
                    ProductName="Iphone14",
                    Price=64_000,
                    Category= new Category() { CategoryId=2,CategoryName="Electronic"}
                },
                new Product(){
                    ProductId=3,
                    ProductName="Macbook",
                    Price=45_000,
                    Category= new Category() { CategoryId=3,CategoryName="Electronic"}
                 }
            };
        }
    }
}
