using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_table_tipModel
    {
        [PrimaryKey]
        public int nrrendor { get; set; }
        public int? id_sup { get; set; }
        public bool? elcat { get; set; }
        public string kodi { get; set; }
        public int? kodifillim { get; set; }
        public int? kodimbarim { get; set; }
        public int? kodiaktual { get; set; }
        public string emertimi { get; set; }
        public string pershkrimi { get; set; }
        public string emertimiang { get; set; }
        public string pershkrimiang { get; set; }
     
        public bool? Aktiv { get; set; }
        public float? rradha { get; set; }
        public int? Perdorues_id { get; set; }
    }
}