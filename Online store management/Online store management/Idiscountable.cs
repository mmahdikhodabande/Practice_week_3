using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_management
{
    internal interface Idiscountable
    {
        decimal ApplyDiscount(decimal Discount_percentage);
    }
}
