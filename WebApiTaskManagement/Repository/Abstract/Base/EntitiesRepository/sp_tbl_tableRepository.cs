using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_tableRepository
    {
        private readonly string _constring;
        public sp_tbl_tableRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_tbl_table(tbl_table_Model tab, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename , sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", tab.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@tip_id", tab.tip_id));
                    cmd.Parameters.Add(new SqlParameter("@kodi", tab.kodi));
                    cmd.Parameters.Add(new SqlParameter("@Emertim", tab.Emertimi));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimi", tab.pershkrimi));
                    cmd.Parameters.Add(new SqlParameter("@Emertimiang", tab.Emertimiang));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimiang", tab.pershkrimiang));
                    cmd.Parameters.Add(new SqlParameter("@Perdorues_id", tab.Perdorues_id));
                    cmd.Parameters.Add(new SqlParameter("@kategoria", tab.kategoria));
                    cmd.Parameters.Add(new SqlParameter("@kompleks", tab.kompleks));



                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }



        public async Task spu_tbl_table_(tbl_table_Model tab, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename, sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nrrendor", tab.nrrendor));

                    if (tab.id_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", tab.id_sup));
                    }

                    if (tab.tip_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_tip_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@tip_id", tab.tip_id));
                    }
                    if (tab.kodi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kodi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@kodi", tab.kodi));
                    }
                    if (tab.Emertimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimi", tab.Emertimi));
                    }
                    if (tab.pershkrimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimi", tab.pershkrimi));
                    }
                    if (tab.Emertimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimiang", tab.Emertimiang));
                    }
                    if (tab.pershkrimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimiang", tab.pershkrimiang));
                    }

                   

                    if (tab.Aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Aktiv", tab.Aktiv));
                    }

                    if (tab.Perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Perdorues_id", tab.Perdorues_id));
                    }

                    if (tab.kategoria is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kategoria", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@kategoria", tab.kategoria));
                    }
                    if (tab.kompleks is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kompleks", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@komplek", tab.kompleks));
                    }



                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }
    }
}
