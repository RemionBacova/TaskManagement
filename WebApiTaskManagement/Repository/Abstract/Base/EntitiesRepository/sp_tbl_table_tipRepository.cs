using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Base.EntitiesRepository
{
    public class sp_tbl_table_tipRepository
    {
        private readonly string _constring;
        public sp_tbl_table_tipRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Tipi(tbl_table_tipModel t,string tablename)
        {
           
          

            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_tip", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", t.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@elcat", t.elcat));
                    cmd.Parameters.Add(new SqlParameter("@kodi", t.kodi));
                    cmd.Parameters.Add(new SqlParameter("@kodifillim",t.kodifillim));
                    cmd.Parameters.Add(new SqlParameter("@kodimbarim",t.kodimbarim));
                    cmd.Parameters.Add(new SqlParameter("@kodiaktual",t.kodiaktual));
                    cmd.Parameters.Add(new SqlParameter("@Emertimi",t.emertimi));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimi", t.pershkrimi));
                    cmd.Parameters.Add(new SqlParameter("@Emertimiang", t.emertimiang));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimiang",t.pershkrimiang));
                    cmd.Parameters.Add(new SqlParameter("@rradha", t.rradha));
                    cmd.Parameters.Add(new SqlParameter("@Perdorues_id", t.Perdorues_id));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }


      
        public async Task spu_tipi(tbl_table_tipModel t, string tablename)
        {
          
        
            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_tip", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nrrendor", t.nrrendor));
                    
                    if (t.id_sup is null ) {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", t.id_sup));
                    }
                  
                    if (t.elcat is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_elcat", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@elcat", t.elcat));
                    }
                    if (t.kodi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kodi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@kodi", t.kodi));
                    }
                    if (t.kodifillim is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kodifillim", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@kodifillim", t.kodifillim));
                    }
                    if (t.kodimbarim is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kodimbarim", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@kodimbarim", t.kodimbarim));
                    }
                    if (t.kodiaktual is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kodiaktual", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@kodiaktual", t.kodiaktual));
                    }
                    if (t.emertimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimi", t.emertimi));
                    }
                    if (t.pershkrimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimi", t.pershkrimi));
                    }
                    if (t.emertimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimiang", t.emertimiang));
                    }
                    if (t.pershkrimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimiang", t.pershkrimiang));
                    }

                    if (t.Aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Aktiv", t.Aktiv));
                    }

                    if (t.Perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Perdorues_id", t.Perdorues_id));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }
    }
}
