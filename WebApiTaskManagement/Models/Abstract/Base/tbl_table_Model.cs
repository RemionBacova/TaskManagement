using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_table_Model
    {
        [PrimaryKey]
        public int nrrendor { get; set; }
        public int? id_sup { get; set; }
        public int? tip_id { get; set; }
        public int? kodi { get; set; }
        public string Emertimi { get; set; }
        public string pershkrimi { get; set; }
        public string Emertimiang { get; set; }
        public string pershkrimiang { get; set; }
        public bool? Aktiv { get; set; }
        public int? Perdorues_id { get; set; }
        public int? kategoria { get; set; }
        public bool? kompleks { get; set; }
    }
}
