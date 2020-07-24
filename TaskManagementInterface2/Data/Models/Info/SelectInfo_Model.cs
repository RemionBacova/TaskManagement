using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementInterface.Data.Models.Info
{
    public class SelectInfo_Model
    {
        public int uid { get; set; }
        public string value { get; set; }
        public string nomination { get; set; }
        public int? element_uid { get; set; }
        public int? type_info_uid { get; set; }

    }
}
