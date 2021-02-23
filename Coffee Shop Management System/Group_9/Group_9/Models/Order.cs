using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Models
{
    public class Order
    {
        public int Order_id { get; set; }
        public string Item_Name { get; set; }
        public string Price { get; set; }
        public string Customer_Username { get; set; }
    }
}
