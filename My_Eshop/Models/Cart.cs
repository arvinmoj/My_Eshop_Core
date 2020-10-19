using System;
using System.Linq;
using System.Collections.Generic;

namespace My_Eshop.Models
{
    public class Cart
    {
        public Cart()
        {
            CartItem = new List<CartItem>();
        }

        public int OrderId { get; set; }

        public List<CartItem> CartItem { get; set; }

        public void addItem(CartItem item)
        {
            if (CartItem.Exists(i => i.Item.Id == item.Id))
            {
                CartItem.Find(i => i.Item.Id == item.Item.Id)
                    .Quantity += 1;
            }
            else
            {
                CartItem.Add(item);
            }
        }

        public void  removeItem (int itemId)
        {

            var itme = CartItem
                .SingleOrDefault(c => c.Item.Id == itemId);

            if (itme?.Quantity <= 1)
            {
                CartItem.Remove(itme);
            }

            else if (itme != null)
            {
                itme.Quantity -= 1;
            }

        }
    }
}
