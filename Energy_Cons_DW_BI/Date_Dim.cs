using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Cons_DW_BI
{
    
    class Date_Dim
    {
        private int day_of_month, year;
        private string day_of_week, name_of_month;

        public Date_Dim(int day_of_month, string day_of_week, string name_of_month, int year)
        {
            this.day_of_month = day_of_month;
            this.day_of_week = day_of_week;
            this.year = year;
            this.name_of_month = name_of_month;
        }

        public int DAY_OF_MONTH
        {
            get{return day_of_month;}
            set{day_of_month = value;}
        }

        public int YEAR
        {
            get { return year; }
            set { year = value; }
        }

        public string DAY_OF_WEEK
        {
            get { return day_of_week; }
            set { day_of_week = value; }
        }

        public string NAME_OF_MONTH
        {
            get { return name_of_month; }
            set { name_of_month = value; }
        }
    }
}
