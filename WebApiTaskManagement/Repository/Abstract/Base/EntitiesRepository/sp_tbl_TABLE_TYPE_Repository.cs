using Dapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Base.EntitiesRepository
{

    public class sp_tbl_TABLE_TYPE_Repository
    {
        private readonly string _constring;
        private int error_id;
        public sp_tbl_TABLE_TYPE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }


        #region SPI_TYPE
        public async Task<IEnumerable<SelectError_Model>> spi_Tipi2(string tablename, int? uid_sup, bool? elcat, string? code, string? codeend, string? nomination, string? description
            , string? description1, string? description2, int? user_uid,int? cat_uid)
        {
            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename + "_TYPE2";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@uid_sup", uid_sup);
                queryParameters.Add("@elcat", elcat);
                queryParameters.Add("@code", code);
                queryParameters.Add("@codeend", codeend);
                queryParameters.Add("@nomination", nomination);
                queryParameters.Add("@description", description);
                queryParameters.Add("@description1", description1);
                queryParameters.Add("@description2", description2);
                queryParameters.Add("@user_uid", user_uid);
                queryParameters.Add("@category_uid", cat_uid);

                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }
        }

        public async Task<IEnumerable<SelectError_Model>> spi_Tipi(string tablename, int? uid_sup, bool? elcat, string? code, string? codeend, string? nomination, string? description
           , string? description1, string? description2, int? user_uid)
        {
            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename + "_TYPE";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@uid_sup", uid_sup);
                queryParameters.Add("@elcat", elcat);
                queryParameters.Add("@code", code);
                queryParameters.Add("@codeend", codeend);
                queryParameters.Add("@nomination", nomination);
                queryParameters.Add("@description", description);
                queryParameters.Add("@description1", description1);
                queryParameters.Add("@description2", description2);
                queryParameters.Add("@user_uid", user_uid);
                

                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }
        }


        #endregion

        #region SPU_TYPE
        public async Task<IEnumerable<SelectError_Model>> spu_tipi(string tablename,int?uid,int? uid_sup, bool? elcat, string? code 
            ,  string? codeend, string? nomination, string? description, string? description1, string? description2, int? user_uid)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_TYPE";
                var queryParameters = new DynamicParameters();


                queryParameters.Add("@UID", uid);

                if (uid_sup is null )
                {
                    queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                }
                else
                {
                    queryParameters.Add("@UID_SUP",uid_sup);
                }

                if (elcat is null)
                {
                    queryParameters.Add("@CONSIDERNULL_ELCAT", 1);
                }
                else
                {
                    queryParameters.Add("@elcat",elcat);
                }
                if (code is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODE", 1);
                }
                else
                {
                    queryParameters.Add("@CODE",code);
                }
                
                if (codeend is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODEEND", 1);
                }
                else
                {
                    queryParameters.Add("@CODEEND",codeend);
                }
                
                if (nomination is null)
                {
                    queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                }
                else
                {
                    queryParameters.Add("@NOMINATION",nomination);
                }
                if (description is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION",description);
                }
                if (description1 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRTIPTION2",description1);
                }
                if (description2 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION3", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRTIPTION3",description2);
                }

                if (user_uid is null)
                {
                    queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                }
                else
                {
                    queryParameters.Add("@USER_UID",user_uid);
                }


                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

        }
        #endregion

        #region SP_SelectAllActiveRec
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectAllActiveRec(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRec";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_TYPE");
                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByUID(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_TYPE");
                queryParameters.Add("@uid", UID);
                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #region SP_SelectActiveTypeByCategory
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveTypeByCategory(string tableName, string? category_uid)
        {

            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveTypesByCategory";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", tableName);
                queryParameters.Add("@category_uid", category_uid);

                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }


        #endregion

        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName + "_TYPE");
                queryParameters.Add("@UID", UID);
               return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                
            }
        }
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByParameters(string tableName, string? uid_sup, string? nomination, string? description)
        {

            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByParameters";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", tableName + "_TYPE");
                if (uid_sup is null)
                {
                    queryParameters.Add("@uid_sup", "");
                }
                else
                {
                    queryParameters.Add("@uid_sup", uid_sup);
                }
                if (nomination is null)
                {
                    queryParameters.Add("@nomination", "%");
                }
                else
                {
                    queryParameters.Add("@nomination", nomination);
                }
                if (description is null)
                {
                    queryParameters.Add("@description", "%");
                }
                else
                {
                    queryParameters.Add("@description", description);
                }

                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #region SP_SelectAllActivByParent
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model1>> SelectAllActiveRecWithParent(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRecWithParent";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_TYPE");
                return await db.QueryAsync<tbl_TABLE_TYPE_Model1>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion


        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> spGetTree(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "GetTree";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName + "_TYPE");
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> GetPossibleParents(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "GetPossibleParents";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName + "_TYPE");
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }



    }
}