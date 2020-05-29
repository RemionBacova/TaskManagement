using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_nder_table_kategoriRepository
    {
        private readonly string _constring;
        public sp_tbl_nder_table_kategoriRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_nder_table_kategori(tbl_INTER_TABLE_CATEGORY_Model nt, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_INTER_" + tablename + "_CATEGORY", sql))
                {
                  
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_uid", nt.table_uid));
                 
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_category_uid", nt.table_category_uid));
                 
                 
                    cmd.Parameters.Add(new SqlParameter("@user_uid", nt.user_uid));
                    


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }

      



    }
}
