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
    public class Type_Repository
    {
        private readonly string _constring;

        public Type_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<Type_Model>> SelectEntitites()
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectType";
                return await db.QueryAsync<Type_Model>(readSp, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
