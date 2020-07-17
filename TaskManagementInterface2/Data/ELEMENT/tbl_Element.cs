using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementInterface.Data.ELEMENT
{
    public class tbl_Element
    {
        public int uid { get; set; }
        public int? uid_sup { get; set; }

        [Required]
        public int? type_uid { get; set; }
        public string code { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string description1 { get; set; }
        public string description2 { get; set; }
        public bool? active { get; set; }
        public int? user_uid { get; set; }
        public int? category { get; set; }
        public bool? complex { get; set; }

        public string type { get; set; }
    }
}
