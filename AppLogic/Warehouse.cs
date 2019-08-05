using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class Warehouse
    {
        public string wh_name { get; set; }
        public string wh_desc { get; set; }
        public int type_id { get; set; }
        public int location_id { get; set; }
        public int cat_id { get; set; }
        public bool isActive { get; set; }
        public int uid { get; set; }
        public int b_entity_id { get; set; }
    }

}
