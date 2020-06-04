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
    public class sp_tbl_INTER_TABLE_TABLE_Repository
    {
        private readonly string _constring;
        public sp_tbl_INTER_TABLE_TABLE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }
        #region spi_inter_table_table
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> spi_nder_table_table(tbl_INTER_TABLE_TABLE m)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_INTER_TABLE1_TABLE2";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@" + m.table1_name+"_name" , m.table1_name);
                queryParameters.Add("@" + m.table2_name +"_name", m.table2_name);
                queryParameters.Add("@" + m.table1_uid + "_uid", m.table1_uid);
                queryParameters.Add("@" + m.table2_uid + "_uid", m.table2_uid);
                queryParameters.Add("@users_uid", m.users_uid);


                return await sql.QueryAsync<tbl_INTER_TABLE_TABLE>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }

        }
        #endregion

    }
}



