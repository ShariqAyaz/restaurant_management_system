using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class Item
    {
        public string iname { get; set; }
        public string idesc { get; set; }
        public string ibarcode { get; set; }
        public int main_cat_id { get; set; }
        public int sub_cat_id { get; set; }
        public int uom_purchase_id { get; set; }
        public int uom_consumption_id { get; set; }
        public decimal divisible_uop { get; set; }
        public int uid { get; set; }
        public int acc_id { get; set; }
    }
}
