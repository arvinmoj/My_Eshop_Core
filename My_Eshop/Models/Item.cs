using System;
namespace My_Eshop.Models
{
    public class Item
    {
        public Item() : base()
        {
        }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }

        public Product Product { get; set; }

    }
}
