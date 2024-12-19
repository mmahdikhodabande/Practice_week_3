using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Online_store_management
{
    internal class Electronic : Product, Idiscountable
    {
        public int WarrantyPeriod { get; set; }

        public decimal ApplyDiscount(decimal Discount_percentage)
        {
            decimal discountAmount = Price * Discount_percentage /100;
            Price -= discountAmount;
            return Price;
        }

        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $"this electronic product Warranty Period is :{WarrantyPeriod } ";
        }
    }
}
