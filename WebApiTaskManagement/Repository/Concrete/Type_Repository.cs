using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTaskManagement.Repository.Concrete
{
    public class Type_Repository
    {
        private readonly string _constring;

        public Type_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<Type>> SelectEntitites()
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectType";
                return await db.QueryAsync<Type>(readSp, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
