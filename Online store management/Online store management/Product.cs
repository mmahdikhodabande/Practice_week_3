using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_management
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual string GetProductDetails()
        {
            return ($"the name of product is: {Name} and price is : {Price}");
        }
    }
}
