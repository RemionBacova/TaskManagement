using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_INTER_TABLE_TABLE
    {
        public string table1_name { get; set; }
        public string table2_name { get; set; }
        public string table1_uid { get; set; }
        public string table2_uid { get; set; }
        public string users_uid { get; set; }
    }
}
