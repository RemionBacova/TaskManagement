using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_table_accessModel
    {
        public string id_gen { get; set; }
        public int id_sup { get; set; }
        public string id_sup_gen { get; set; }
        public int id_ndr { get; set; }
        public string id_ndr_gen { get; set; }
        public int Entitet_Table_id { get; set; }
        public string Entitet_Table_id_gen { get; set; }
        public int perdoruesi_id  { get; set; }
        public string perdoruesi_id_gen { get; set; }
        public Boolean aktiv { get; set; }
        public DateTime data_krijimit { get; set; }
        public int perdorues_id  { get; set; }
        public string perdorues_id_gen { get; set; }

    }
}
