using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_INTER_TABLE_TYPE_CATEGORY_Repository
    {
        private readonly string _constring;
        public sp_tbl_INTER_TABLE_TYPE_CATEGORY_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_nder_tip_kateogori(tbl_INTER_TABLE_TYPE_CATEGORY_Model ntk, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_nder_" + tablename + "_tip_kategori", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                  
                    cmd.Parameters.Add(new SqlParameter("@" +tablename+"_type_uid", ntk.table_type_uid));
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_type_category_uid", ntk.table_type_category_uid));
                    cmd.Parameters.Add(new SqlParameter("@user_uid", ntk.user_uid));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }

       







        }
    }
