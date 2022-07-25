using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class WipProductionEntry
    {
        public int doc_id { get; set; }
        public int source_whid { get; set; }
        public DateTime tdate { get; set; }
        public decimal wip_produce_qty { get; set;}
        public decimal iid_consume_qty { get; set; }
        public int issue_dept_id { get; set; }
        public int iid { get; set; }
        public int wip_item_id { get; set; }
        public int uid { get; set; }
        public int b_entity_id { get; set; }
        public string remarks { get; set; }
    }
}
