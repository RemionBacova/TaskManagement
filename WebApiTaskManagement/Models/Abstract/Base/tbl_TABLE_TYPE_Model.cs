using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_TABLE_TYPE_Model
    {
        [PrimaryKey]
        public int uid { get; set; }
        public int? uid_sup { get; set; }
        public bool? elcat { get; set; }
        public string code { get; set; }
        public int? codebegin { get; set; }
        public int? codeend { get; set; }
        public int? codeactual { get; set; }
        public string nomination { get; set; }
        public string description { get; set; }
        public string description1 { get; set; }
        public string description2 { get; set; }
        public bool? active { get; set; }
        public float? queue { get; set; }
        public int? user_uid { get; set; }
    }
}