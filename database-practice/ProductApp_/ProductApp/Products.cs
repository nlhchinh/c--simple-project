using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    class Products
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }

        public Products(string productID, string productName, string category, string description, DateTime date
            )
        {
            this.productID = productID;
            this.productName = productName;
            this.category = category;
            this.description = description;
            this.date = date;
        }
    }
}
