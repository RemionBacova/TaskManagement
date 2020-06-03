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
    public class sp_tbl_TABLE_INFO_Repository
    {
        #region IConfiguration
        private readonly string _constring;
        public sp_tbl_TABLE_INFO_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        #endregion

        #region SPI_INFO
        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> spi_Info( string tablename, int? uid_sup, int? element_uid, int? type_info_uid, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_"+tablename+"_INFO";
                var queryParameters = new DynamicParameters();
                
                    queryParameters.Add("@uid_sup", uid_sup);
                    queryParameters.Add("@element_uid", element_uid);
                    queryParameters.Add("@type_info_id", type_info_uid);
                    queryParameters.Add("@nomination", nomination);
                    queryParameters.Add("@description", description);
                    queryParameters.Add("@description1", description1);
                    queryParameters.Add("@description2", description2);
                    queryParameters.Add("@user_uid", user_uid);

                return await sql.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }

            }
        #endregion

        #region SPU_INFO
        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> spu_Info( string tablename ,int?uid,int? uid_sup, int? element_uid, int? type_info_uid, string? nomination, string? description
            , string? description1, string? description2, int? user_uid)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_INFO";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@UID", uid);

                    if (uid_sup is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                    }
                    else
                    {
                        queryParameters.Add("@UID_SUP", uid_sup);
                    }

                    if (element_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_ELEMENT_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@ELEMENT_UID", element_uid);
                    }
                    if (type_info_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_TYPE_INFO_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@TYPE_INFO_UID", type_info_uid);
                    }

                    if (nomination is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                    }
                    else
                    {
                        queryParameters.Add("@NOMINATION", nomination);
                    }
                    if (description is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION", description);
                    }
                    if (description1 is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION2", description1);
                    }
                    if (description2 is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION3", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION3", description2);
                    }

                  

                    if (user_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@USER_UID", user_uid);
                    }

                return await sql.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }

            }
        #endregion

        #region SP_SelectAllActiveRec
        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> SelectAllActiveRec(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRec";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_"+tableName+"_INFO");
                return await db.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SP_SelectByUID
        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> SelectActiveRecByUID(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_INFO");
                queryParameters.Add("@uid", UID);
                return await db.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SP_DeleteRow
        public async Task<Boolean> DeleteRow(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName + "_INFO");
                queryParameters.Add("@UID", UID);
                await db.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
        #endregion

        #region SP_SelectByParameters
        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> SelectActiveRecByParameters(string tableName, string? uid_sup, string? nomination, string? description)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByParameters";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", tableName + "_INFO");
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

                return await db.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

    }
}

