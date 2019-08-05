using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class Vendor_payment
    {
        public int vpno { get; set; }
        public int vendor_id { get; set; }
        public int uid { get; set; }
        public int cr_acc_id { get; set; }
        public int b_entity_id { get; set; }
        public DateTime vDate { get; set; }
        public string remarks { get; set; }
        public decimal dramt { get; set; }
        public bool isPosted { get; set; }

    }
}
