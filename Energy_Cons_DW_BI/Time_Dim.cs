using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Cons_DW_BI
{
    class Time_Dim
    {
        private int time_hour_min;

        public Time_Dim(int time_hour_min)
        {
            this.time_hour_min = time_hour_min;
        }

        public int TIME_VAL
        {
            get { return time_hour_min; }
            set { time_hour_min = value; }
        }
    }
}
