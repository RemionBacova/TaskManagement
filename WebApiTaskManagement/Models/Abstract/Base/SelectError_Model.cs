using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public class SelectError_Model
    {
        public int? EID { get; set; }
        public int? TID { get; set; }
        public int? LID { get; set; }
        public DateTime CREATION_DATE { get; set; }       
        public string? TIDGEN { get; set; }
        public string? ERRORNAME{ get; set; }
        public string? ERRORDESCRIPTION { get; set; }
        public string? NAME_SP{ get; set; }
        public string? PARAMETERS { get; set; }


    }
}
