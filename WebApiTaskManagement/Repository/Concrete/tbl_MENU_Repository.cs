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
    public class tbl_MENU_Repository
    {
        private readonly string _constring;

        public tbl_MENU_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_Menu_Model>> SelectMenus()
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectMENUS";
                return await db.QueryAsync<tbl_Menu_Model>(readSp, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<IEnumerable<tbl_Menu_Model>> SelectMenuByparentUid(string uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectMENUSByIdSup";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@parentuid", uid);
                return await db.QueryAsync<tbl_Menu_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<IEnumerable<tbl_Menu_Model>> SelectMenuByUserId(string uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectMENUSByUserId";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@userid", uid);

                return await db.QueryAsync<tbl_Menu_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
