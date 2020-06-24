using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models
{
    public class tbl_Entities_Model

    {
        public int UID { get; set; }
        public string UID_GEN { get; set; }
        public string NOMINATION { get; set; }
        public string DESCRIPTION { get; set; }

        public DateTime CREATION_DATE { get; set; }

        public int USER_UID { get; set; }
        public string USER_UID_GEN { get; set; }


    }
}
