using System;
using System.Collections.Generic;

namespace My_Eshop.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int  ItemId { get; set; }

        public ICollection<CategoryToProduct> categoryToProducts { get; set; }

        public Item Item { get; set; }
    }
}
