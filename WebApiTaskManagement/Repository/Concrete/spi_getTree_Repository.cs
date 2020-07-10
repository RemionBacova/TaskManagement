using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Concrete;

namespace WebApiTaskManagement.Repository.Concrete
{
    public class spi_getTree_Repository
    {
        private readonly string _constring;

        public spi_getTree_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<spi_GetTreeModel>>spGetTree(string TABLE ,string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "GetTree";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", TABLE);
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<spi_GetTreeModel>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }


        public async Task<IEnumerable<spi_GetTreeModel>> GetPossibleParents(string TABLE, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "GetPossibleParents";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", TABLE);
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<spi_GetTreeModel>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }


    }
}
