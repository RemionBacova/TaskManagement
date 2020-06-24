using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models;

namespace WebApiTaskManagement.Repository
{
    public class tbl_ENTITIES_Repository
    {
        private readonly string _constring;
       
        public tbl_ENTITIES_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_Entities_Model>> SelectEntitites()
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectENTITIES";
                return await db.QueryAsync<tbl_Entities_Model>(readSp, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
