using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Base.EntitiesRepository
{
    public class sp_tbl_table_accessRepository
    {
        private readonly string _constring;
        public sp_tbl_table_accessRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }



        public async Task spi_access(tbl_table_accessModel a, string tablename)
        {
          
            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_access", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", a.id_gen));
                    cmd.Parameters.Add(new SqlParameter("@id_sup", a.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@id_sup_gen", a.id_sup_gen));
                    cmd.Parameters.Add(new SqlParameter("@id_ndr", a.id_ndr));
                    cmd.Parameters.Add(new SqlParameter("@id_ndr_gen", a.id_ndr_gen));
                    cmd.Parameters.Add(new SqlParameter("@" +tablename + "_id", a.Entitet_Table_id));
                    cmd.Parameters.Add(new SqlParameter("@"+tablename+"_id_gen", a.Entitet_Table_id_gen));
                    cmd.Parameters.Add(new SqlParameter("@perdoruesi_id", a.perdoruesi_id));
                    cmd.Parameters.Add(new SqlParameter("@perdoruesi_id_gen", a.perdoruesi_id_gen));
                    cmd.Parameters.Add(new SqlParameter("@aktiv", a.aktiv));
                    cmd.Parameters.Add(new SqlParameter("@data_krijimit", a.data_krijimit));
                    cmd.Parameters.Add(new SqlParameter("@perdorues_id", a.perdorues_id));
                    cmd.Parameters.Add(new SqlParameter("@perdorues_id_gen", a.perdorues_id_gen));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }



        public async Task spu_access(tbl_table_accessModel a,string tablename)
        {
         

            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_access", sql))
                {
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_id",a.Entitet_Table_id));
                   
                    cmd.Parameters.Add(new SqlParameter("@perdoruesi_id", a.perdoruesi_id));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }



    }
}
