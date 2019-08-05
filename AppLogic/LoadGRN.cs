using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class LoadGRN
    {
        public int grn_no { get; set; }
        public int vendor_id { get; set; }
        public int uid { get; set; }
        public int b_entity_id { get; set; }
        public DateTime GRDate { get; set; }
        public string supplier_invoice { get; set; }
        public string remarks { get; set; }
        public bool isPosted { get; set; }
    }
}
