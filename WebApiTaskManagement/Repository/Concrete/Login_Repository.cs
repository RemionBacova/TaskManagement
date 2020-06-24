using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Models.LoginModels;

namespace WebApiTaskManagement.Repository.Concrete
{
    public class Login_Repository
    {
        private readonly string _constring;

        public Login_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<int> Login(LoginModel l)
        {

            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "UserLogin";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Username", l.username);
                queryParameters.Add("@Password", l.password);

                return await db.QuerySingleAsync<int>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<int> ChangePassword(ChangePassword p)
        {

            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "UserChangePassword";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@username", p.username);
                queryParameters.Add("@OldPassword", p.OldPassword);
                queryParameters.Add("@NewPassword", p.NewPassword);

                return await db.QuerySingleAsync<int>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
