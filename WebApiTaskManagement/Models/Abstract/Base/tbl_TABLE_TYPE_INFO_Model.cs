using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public class tbl_TABLE_TYPE_INFO_Model
    {
        [PrimaryKey]
        public int uid { get; set; }
        public int? uid_sup { get; set; }
        public int ?   type_uid { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string description1 { get; set; }
        public string description2 { get; set; }
        public int? property { get; set; }
        public bool? mandatory { get; set; }
        public float? queue{ get; set; }
        public int? db { get; set; }
        public bool? file { get; set; }
        public bool? active { get; set; }
        public int? user_uid { get; set; }
    }
}
