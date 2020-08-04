using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiUploadFile.Models
{
    public class tbl_Files
    {

        public int uid { get; set; }
        public int? uid_sup { get; set; }
        public int? element_uid { get; set; }
        public int? type_info_uid { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string entity { get; set; }
        public bool? active { get; set; }
        public int? user_uid { get; set; }
        public string file { get; set; }
        public string file_type_uid { get; set; }

    }
}
