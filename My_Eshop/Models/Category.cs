using System;
using System.Collections.Generic;

namespace My_Eshop.Models
{
    public class Category
    {
        public Category() : base()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public  ICollection<CategoryToProduct>  CategotyToProducts { get; set; }

    }
}
