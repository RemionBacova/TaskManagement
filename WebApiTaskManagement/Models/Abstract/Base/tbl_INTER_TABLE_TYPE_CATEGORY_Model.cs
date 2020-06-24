using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract
{
    public abstract class tbl_INTER_TABLE_TYPE_CATEGORY_Model
    {
  
   

        public int? table_type_uid { get; set; }    
        public int? table_type_category_uid { get; set; }  
        public string user_uid { get; set; }
    }
}
