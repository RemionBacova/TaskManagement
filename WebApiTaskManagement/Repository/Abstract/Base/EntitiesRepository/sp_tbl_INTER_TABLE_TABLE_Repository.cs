using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_INTER_TABLE_TABLE_Repository
    {
        private readonly string _constring;
        private int error_id;
   
        public sp_tbl_INTER_TABLE_TABLE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");


        }
        #region spi_inter_table_table
        public async Task<IEnumerable<SelectError_Model>> spi_nder_table_table(string?table1_name,string?table2_name,int?table1_uid,
            int?table2_uid,int?users_uid)
        {

            try
            {

                using (IDbConnection sql = new SqlConnection(_constring))
                {

                    string readSp = "spI_tbl_INTER_TABLE1_TABLE2";
                    var queryParameters = new DynamicParameters();

                    queryParameters.Add("@table1_name ", table1_name);
                    queryParameters.Add("@table2_name", table2_name);
                    queryParameters.Add("@table1_uid", table1_uid);
                    queryParameters.Add("@table2_uid", table2_uid);
                    queryParameters.Add("@users_uid", users_uid);


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
        #endregion

        #region sp_deleterow
        public async Task<Boolean> DeleteRow(string tableName1,string tableName2, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_INTER_" + tableName1 + "_"+tableName2);
                queryParameters.Add("@UID", UID);
                await db.QueryAsync<tbl_INTER_TABLE_TABLE>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }

        #endregion

        #region sp_get
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> SelectConnections(string table1,string table2)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveConnections_TABLE1_TABLE2";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table1_name", table1);
                queryParameters.Add("@table2_name", table2);
                return await db.QueryAsync<tbl_INTER_TABLE_TABLE>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region sp_SelectLastUid
        public async Task<IEnumerable<sp_select_lastUID>> SelectLastUid(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectLastUid";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName);
                return await db.QueryAsync<sp_select_lastUID>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region sp_SelectAllActiveConnections_TABLE1_TABLE2_Table2_UID
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> SelectAllActiveConnections_TABLE1_TABLE2_Table2_UID(string? table1, string? table2, int? table2_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveConnections_TABLE1_TABLE2_Table1_ID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table1_name", table1);
                queryParameters.Add("@table2_name", table2);
                queryParameters.Add("@table2_uid", table2_uid);
                return await db.QueryAsync<tbl_INTER_TABLE_TABLE>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region sp_SelectAllActiveConnections_TABLE1_TABLE2_Table1_UID
        public async Task<IEnumerable<tbl_INTER_TABLE_TABLE>> SelectAllActiveConnections_TABLE1_TABLE2_Table1_UID(string? table1, string? table2, int? table1_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveConnections_TABLE1_TABLE2_Table1_ID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table1_name", table1);
                queryParameters.Add("@table2_name", table2);
                queryParameters.Add("@table1_uid", table1_uid);
                return await db.QueryAsync<tbl_INTER_TABLE_TABLE>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region sp_INTER_TABLE_CATEGORY
        public async Task<IEnumerable<SelectError_Model>> sp_INTER_TABLE_CATEGORY(string? tablename, string? table_uid, string? tablecat_uid, string? user_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "spI_tbl_INTER_TABLE_CATEGORY";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@tablename", tablename);
                queryParameters.Add("@table_uid", table_uid);
                queryParameters.Add("@table_category_uid", tablecat_uid);
                queryParameters.Add("@users_uid", user_uid);
                return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region sp_INTER_TABLE_TYPE_CATEGORY
        public async Task<IEnumerable<SelectError_Model>> Sp_INTER_TABLE_TYPE_CATEGORY(string? tablename, string? tabletype_uid, string? tabletype_cat_uid, string? user_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "spI_tbl_INTER_TABLE_TYPE_CATEGORY";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@tablename", tablename);
                queryParameters.Add("@table_type_uid", tabletype_uid);
                queryParameters.Add("@table_type_category_uid", tabletype_cat_uid);
                queryParameters.Add("@users_uid", user_uid);
                return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

     
    }
}



