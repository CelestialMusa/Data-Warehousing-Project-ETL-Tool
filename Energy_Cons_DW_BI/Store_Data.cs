namespace Energy_Cons_DW_BI
{
    class Store_Data
    {
        private string shop_code, log_timestamp, shop_name, shop_location;
        private double kwh_main, kwh_bakery, kwh_refrigeration, kwh_other;

        public Store_Data(string shop_code, string log_timestamp, double kwh_main, double kwh_bakery, double kwh_refrigeration, double kwh_other)
        {
            this.shop_code = shop_code;
            this.log_timestamp = log_timestamp;
            this.kwh_main = kwh_main;
            this.kwh_bakery = kwh_bakery;
            this.kwh_refrigeration = kwh_refrigeration;
            this.kwh_other = kwh_other;
        }

        public string SHOP_CODE{get { return shop_code; }}

        public string LOG_TIMESTAMP{get { return log_timestamp; }}

        public double KWH_MAIN { get { return kwh_main; } }

        public double KWH_BAKERY { get { return kwh_bakery; } }

        public double KWH_REFRIG { get { return kwh_refrigeration; } }

        public double KWH_OTHER { get { return kwh_other; } }

        public string SHOP_NAME{get{return shop_name;} set {shop_name = value;}}

        public string SHOP_LOCATION {get{return shop_location;} set{shop_location = value;}}
    }
}
