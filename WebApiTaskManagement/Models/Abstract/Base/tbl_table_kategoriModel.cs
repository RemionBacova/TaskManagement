using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_table_kategoriModel
    {
        [PrimaryKey]
        public int nrrendor { get; set; }
        public int? id_sup { get; set; } 
        public bool? elcat { get; set; }

        public string kodi { get; set; }
        public string Emertimi { get; set; }
        public string pershkrimi { get; set; }
        public string Emertimiang { get; set; }
        public string pershkrimiang { get; set; }
        public bool? Aktiv { get; set; }
        public float rradha { get; set; }
        public int? Perdorues_id { get; set; }
    }
}
