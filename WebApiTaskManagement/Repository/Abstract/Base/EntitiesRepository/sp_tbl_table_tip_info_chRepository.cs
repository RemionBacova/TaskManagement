
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_table_tip_info_chRepository
    {
        private readonly string _constring;
        public sp_tbl_table_tip_info_chRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Tip_Info_Ch(tbl_table_tip_info_chModel tich, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_tip_info_ch", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", tich.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@tip_info_id", tich.tip_info_id));
                    cmd.Parameters.Add(new SqlParameter("@Emertim", tich.Emertimi));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimi", tich.pershkrimi));
                    cmd.Parameters.Add(new SqlParameter("@Emertimiang", tich.Emertimiang));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimiang", tich.pershkrimiang));                   
                    cmd.Parameters.Add(new SqlParameter("@Perdorues_id", tich.Perdorues_id));
                    cmd.Parameters.Add(new SqlParameter("@VA", tich.VA));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }

        public async Task spu_Tip_Info_Ch(tbl_table_tip_info_chModel tich, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_tip_info_ch", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nrrendor", tich.nrrendor));

                    if (tich.id_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", tich.id_sup));
                    }

                    if (tich.tip_info_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_tip_info_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@tip_info_id", tich.tip_info_id));
                    }

                    if (tich.Emertimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimi", tich.Emertimi));
                    }
                    if (tich.pershkrimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimi", tich.pershkrimi));
                    }
                    if (tich.Emertimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimiang", tich.Emertimiang));
                    }
                    if (tich.pershkrimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimiang", tich.pershkrimiang));
                    }                  

                    if (tich.Aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Aktiv", tich.Aktiv));
                    }

                    if (tich.Perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Perdorues_id", tich.Perdorues_id));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }


    }
}
