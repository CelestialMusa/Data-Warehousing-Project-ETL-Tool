using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Cons_DW_BI
{
    class Shop_Dim
    {
        string shop_code, shop_name, shop_location;

        public Shop_Dim(string shop_code, string shop_name, string shop_location)
        {
            this.shop_code = shop_code;
            this.shop_name = shop_name;
            this.shop_location = shop_location;
        }

        public string SHOP_CODE
        {
            get { return shop_code; } 
            set { shop_code = value; }
        }

        public string SHOP_NAME
        {
            get { return shop_name; }
            set { shop_name = value; }
        }

        public string SHOP_LOCATION
        {
            get { return shop_location; }
            set { shop_location = value; }
        }
    }
}
