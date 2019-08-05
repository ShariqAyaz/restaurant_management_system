using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class GRN_ITEMS
    {
        public int LID { get;set;}
        public string ITEMBARCODE { get;set;}
        public int IID { get;set;}
        public string ITEMNAME { get; set; }
        public decimal IRATE { get; set; }
        public decimal IQTY { get; set; }
        public decimal IAMT { get; set; }
    }
}
