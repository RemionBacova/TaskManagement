using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract
{
    public abstract class tbl_nder_table_tip_kategoriModel
    {
        [PrimaryKey]
        public int nrrendor{ get; set; }
        public int? id_sup { get; set; }
        public string id_sup_gen { get; set; }
        public int? table_tip { get; set; }

        public int? table_tip_id { get; set; }
        public string table_tip_id_gen { get; set; }
        
        public int? table_tip_kategori_id { get; set; }
        public string table_tip_kategori_id_gen { get; set; }
       
        public bool? aktiv { get; set; }
        //public DateTime data_krijimit { get; set; }
        public int? perdorues_id { get; set; }
        public string perdorues_id_gen { get; set; }
    }
}
