using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public class Product
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }

        public Product(string name, string code, float price, string imageUrl)
        {
            Name = name;
            Code = code; 
            Price = price;
            ImageUrl = imageUrl;
        }

    }
}
