using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_table_tip_infoRepository
    {
        private readonly string _constring;
        public sp_tbl_table_tip_infoRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Tip_Info(tbl_table_tip_infoModel ti, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_tip_info", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", ti.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@tip_id", ti.tip_id));
                    cmd.Parameters.Add(new SqlParameter("@Emertim", ti.Emertimi));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimi", ti.pershkrimi));
                    cmd.Parameters.Add(new SqlParameter("@Emertimiang", ti.Emertimiang));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimiang", ti.pershkrimiang));
                    cmd.Parameters.Add(new SqlParameter("@veti", ti.veti));
                    cmd.Parameters.Add(new SqlParameter("@detyrueshme", ti.detyrueshme));
                    cmd.Parameters.Add(new SqlParameter("@Rradha", ti.Rradha));
                    cmd.Parameters.Add(new SqlParameter("@db", ti.db));
                    cmd.Parameters.Add(new SqlParameter("@skedar", ti.skedar));
                    cmd.Parameters.Add(new SqlParameter("@Perdorues_id", ti.Perdorues_id));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }


        public async Task spu_Tip_Info(tbl_table_tip_infoModel ti, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_tip_info", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nrrendor", ti.nrrendor));

                    if (ti.id_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", ti.id_sup));
                    }

                    if (ti.tip_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_tip_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@tip_id", ti.tip_id));
                    }

                    if (ti.Emertimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimi", ti.Emertimi));
                    }
                    if (ti.pershkrimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimi", ti.pershkrimi));
                    }
                    if (ti.Emertimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Emertimiang", ti.Emertimiang));
                    }
                    if (ti.pershkrimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimiang", ti.pershkrimiang));
                    }

                    if (ti.veti is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_veti", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@veti", ti.veti));
                    }
                    if (ti.detyrueshme is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_detyrueshme", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@detyrueshme", ti.detyrueshme));
                    }
                    if (ti.Rradha is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Rradha", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Rradha", ti.Rradha));
                    }
                    if (ti.db is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_db", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@db", ti.db));
                    }
                    if (ti.skedar is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_skedar", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@skedar", ti.skedar));
                    }

                    if (ti.Aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Aktiv", ti.Aktiv));
                    }

                    if (ti.Perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Perdorues_id", ti.Perdorues_id));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }




    }
}
