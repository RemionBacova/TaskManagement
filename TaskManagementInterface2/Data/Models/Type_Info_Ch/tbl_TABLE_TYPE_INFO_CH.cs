using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementInterface.Data.Models.Type_Info_Ch
{
    public class tbl_TABLE_TYPE_INFO_CH
    {
        public int uid { get; set; }
        public int? uid_sup { get; set; }
        public int? type_info_uid { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string description2 { get; set; }
        public string description3 { get; set; }
        public bool? active { get; set; }
        public int? user_uid { get; set; }
        public bool VA { get; set; }
    }
}
