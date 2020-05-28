using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Models.Abstract.Base
{
    public abstract class tbl_nder_table_kategoriModel
    {

        [PrimaryKey]
       public int nrrendor { get; set; }
       public string id_gen { get; set; }
        public  int? id_sup { get; set; }
        public string id_sup_gen { get; set; }
        public int? id_ndr { get; set; }
        public string id_ndr_gen { get; set; }
        public int? table_id { get; set; }
        public string table_id_gen { get; set; }
        public int? table_kategori_id { get; set; }
        public string table_kategori_id_gen { get; set; }
        public  bool? aktiv { get; set; }
        public DateTime data_krijimit { get; set; }
        public  int? perdorues_id  { get; set; }
        public  string perdorues_id_gen { get; set; }
    }
}
