using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Cons_DW_BI
{
    class Cons_Type_Dim
    {
        private string consumption_type;

        public Cons_Type_Dim(string cons_type)
        {
            this.consumption_type = cons_type;
        }

        public string CONS_TYPE
        {
            get { return consumption_type; }
            set { consumption_type = value; }
        }
    }
}
