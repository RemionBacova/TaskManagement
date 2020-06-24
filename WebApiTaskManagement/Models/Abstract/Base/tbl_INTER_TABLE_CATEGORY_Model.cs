using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_INTER_TABLE_CATEGORY_Model
    {

      
        public int? table_uid { get; set; }
      
        public int? table_category_uid { get; set; }
 
        public  int? user_uid  { get; set; }
       
    }
}
