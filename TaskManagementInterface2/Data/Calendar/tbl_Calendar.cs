using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementInterface.Data.Calendar
{
    public class tbl_TABLE_Model_Calendar
    {

        public int uid { get; set; }
        public int? uid_sup { get; set; }
        public int? type_uid { get; set; }
        public string code { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string description2 { get; set; }
        public string description3 { get; set; }
        public bool? active { get; set; }
        public int? user_uid { get; set; }
        public int? category { get; set; }
        public bool? complex { get; set; }
        public int? calendaR_CATEGORY_UID { get; set; }
    }
}
