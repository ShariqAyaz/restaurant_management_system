using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class LoadPIN
    {
        public int pinno { get; set; }
        public int source_whid { get; set; }
        public int issue_dept_id { get; set; }
        public int iid { get; set; }
        public int uid { get; set; }
        public decimal received_qty { get; set; }
        public DateTime tdate { get; set; }
        public string remarks { get; set; }
        public int b_entity_id { get; set; }
    }
}
