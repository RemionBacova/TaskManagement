using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public  class tbl_TABLE_INFO_Model
    {
        [PrimaryKey]
        public int uid { get; set; }
        public int? uid_sup { get; set; }
        public int? element_uid { get; set; }
        public int? type_info_uid { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string description2 { get; set; }
        public string description3 { get; set; }
        public bool? active { get; set; }
        public int? user_uid { get; set; }

    }
    public class tbl_TABLE_INFO_Model1
    {
        [PrimaryKey]
        public int uid { get; set; }
        public string value { get; set; }
        public int? element_uid { get; set; }
        public int? type_info_uid { get; set; }
        public string nomination { get; set; }
        public int? property { get; set; }
  

    }
}
