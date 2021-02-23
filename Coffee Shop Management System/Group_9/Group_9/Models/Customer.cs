using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_9.Models
{
    public class Customer
    {
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_Username { get; set; }
        public string Password { get; set; }
        public string Phone_no { get; set; }
        public int Shop_id { get; set; }
    }
}
