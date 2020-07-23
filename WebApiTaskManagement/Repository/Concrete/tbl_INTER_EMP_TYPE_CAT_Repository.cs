using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;
using WebApiTaskManagement.Models.Concrete;

namespace WebApiTaskManagement.Repository.Concrete
{
    public class tbl_INTER_EMP_TYPE_CAT_Repository
    {
        private readonly string _constring;

        public tbl_INTER_EMP_TYPE_CAT_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_INTER_EMPLOYE_C_T>> SelectAllActiveRecParam(int? empuid, int? calType_uid,int? calCat_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectInterEmployee_Calendar";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@employee_uid", empuid);
                queryParameters.Add("@calendar_type_uid" , calType_uid);
                queryParameters.Add("@calendar_category_uid" , calCat_uid);
                return await db.QueryAsync<tbl_INTER_EMPLOYE_C_T>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<SelectError_Model>> spi_inter_emp_type_cat(int? empuid, int? calType_uid, int? calCat_uid, int? user_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "spI_tbl_INTER_EMPLOYEES_C_TYPE_CATEGORY";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Employees_uid ", empuid);
                queryParameters.Add("@CALENDAR_type_uid", calType_uid);
                queryParameters.Add("@CALENDAR_category_uid", calCat_uid);
                queryParameters.Add("@users_uid", user_uid);
                return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<SelectError_Model>> DeleteRow( string empUID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRowInter_EMP_C";
                var queryParameters = new DynamicParameters();
                
                queryParameters.Add("@employee_uid", empUID);
                return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                ;
            }
        }

        public async Task<IEnumerable<tbl_INTER_EMPLOYE_C_T>> SelectAllActiveRec()
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllRecInterEmployee_Calendar";
                var queryParameters = new DynamicParameters();
               
                return await db.QueryAsync<tbl_INTER_EMPLOYE_C_T>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }



    }
}

