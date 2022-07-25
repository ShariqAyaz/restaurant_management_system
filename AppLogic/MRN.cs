using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class MRN
    {
        public int doc_id { get; set; }
        public int ven_id { get; set; }
        public DateTime doc_date { get; set; }
        public int iid { get; set; }
        public int whid { get; set; }
        public decimal decrease_qty { get; set; }
        public decimal rate { get; set; }
        public int b_entity_id { get; set; }
        public int uid { get; set; }
        public string remarks { get; set; }
    }
}
