using System;
namespace My_Eshop.Models
{
    public class CartItem
    {
        public CartItem() : base()
        {
        }

        public int Id { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal getTotalPrice() {

            return Item.Price = Quantity;

        }
    }
}
