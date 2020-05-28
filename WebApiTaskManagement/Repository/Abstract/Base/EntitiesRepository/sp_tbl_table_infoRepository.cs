using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_table_infoRepository
    {
        private readonly string _constring;
        public sp_tbl_table_infoRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Info(tbl_table_infoModel i, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_info", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", i.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@elemet_id", i.element_id));
                    cmd.Parameters.Add(new SqlParameter("@tip_info_id", i.tip_info_id));
                    cmd.Parameters.Add(new SqlParameter("@Emertimi", i.Emertimi));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimi", i.pershkrimi));
                    cmd.Parameters.Add(new SqlParameter("@Emertimiang", i.Emertimiang));
                    cmd.Parameters.Add(new SqlParameter("@pershkrimiang", i.pershkrimiang));
                    cmd.Parameters.Add(new SqlParameter("@Perdorues_id", i.Perdorues_id));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }


        public async Task spu_Info(tbl_table_infoModel i, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_info", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nrrendor", i.nrrendor));

                    if (i.id_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", i.id_sup));
                    }

                    if (i.element_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_element_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@element_id", i.element_id));
                    }
                    if (i.tip_info_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_tip_info_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@tip_info_id", i.tip_info_id));
                    }
                 
                    if (i.Emertimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@emertimi",i.Emertimi));
                    }
                    if (i.pershkrimi is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimi", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimi", i.pershkrimi));
                    }
                    if (i.Emertimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@emertimiang", i.Emertimiang));
                    }
                    if (i.pershkrimiang is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimiang", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@pershkrimiang", i.pershkrimiang));
                    }

                    if (i.Aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Aktiv", i.Aktiv));
                    }

                    if (i.Perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Perdorues_id", i.Perdorues_id));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }




    }
}
