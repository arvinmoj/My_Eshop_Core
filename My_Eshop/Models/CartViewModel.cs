using System;
using System.Collections.Generic;

namespace My_Eshop.Models
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            CartItem = new List<CartItem>();
        }

        public List<CartItem> CartItem { get; set; }

        public decimal OrderTotal { get; set; }
    }
}
