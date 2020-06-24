using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models
{
    public class tbl_Menu_Model
    {
		[PrimaryKey]
		[AutoIncrement]
		public int UID { get; set; }
        public string? UID_GEN { get; set; }
		public int? UID_SUP { get; set; }
		public string? UID_SUP_GEN { get; set; }
		public int? UID_NDR { get; set; }
		public string? UID_NDR_GEN { get; set; }
		public string NOMINATION { get; set; }
        public string CODE { get; set; }

		public bool? ELCAT { get; set; }
		public int CONF { get; set; }
		public string? ELEMENT_NOMINATION { get; set; }
		public string? CONTROLLER { get; set; }
		public string? PARAMETERS { get; set; }
		public bool ACTIVE { get; set; }
		public DateTime CREATION_DATE { get; set; }

        public int USER_UID { get; set; }
        public string? USER_UID_GEN { get; set; }
		public int? FILE_ID { get; set; }
		public string? FILE_ID_GEN { get; set; }



	}
}
