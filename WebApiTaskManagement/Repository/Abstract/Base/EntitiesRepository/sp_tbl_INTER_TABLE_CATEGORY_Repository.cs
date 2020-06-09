using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public abstract class sp_tbl_INTER_TABLE_CATEGORY_Repository
    {
        private readonly string _constring;
        private int error_id;
        public sp_tbl_INTER_TABLE_CATEGORY_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<SelectError_Model>> spi_nder_table_kategori(tbl_INTER_TABLE_CATEGORY_Model nt, string tablename)
        {

            try
            {
                using (IDbConnection sql = new SqlConnection(_constring))
                {

                    string readSp = "spI_tbl_INTER_" + tablename + "_CATEGORY";
                    var queryParameters = new DynamicParameters();

                    queryParameters.Add("@" + tablename + "_uid", nt.table_uid);
                    queryParameters.Add("@" + tablename + "_category_uid", nt.table_category_uid);
                    queryParameters.Add("@user_uid", nt.user_uid);


                    return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


                }

            }
            catch
            {
                using (IDbConnection db = new SqlConnection(_constring))
                {
                    string readSp = "select_Error";
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@error_id", error_id);

                    return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                }

            }

          
        }
    }
}

      



    
