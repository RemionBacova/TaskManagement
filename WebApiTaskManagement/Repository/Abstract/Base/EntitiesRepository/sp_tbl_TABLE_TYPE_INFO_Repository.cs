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
    public  class sp_tbl_TABLE_TYPE_INFO_Repository
    {
        private readonly string _constring;
        private int error_id;
        public sp_tbl_TABLE_TYPE_INFO_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<SelectError_Model>> spi_Tip_Info(string tablename, int? uid_sup, int? type_uid, string? nomination, string? description
            , string? description1, string? description2, int?property,bool?mandatory,int?db,bool?file,int? user_uid)
        {
            try
            {
                using (IDbConnection sql = new SqlConnection(_constring))
                {

                    string readSp = "spI_tbl_" + tablename + "_TYPE_INFO";
                    var queryParameters = new DynamicParameters();

                    queryParameters.Add("@uid_sup", uid_sup);
                    queryParameters.Add("@type_id", type_uid);
                    queryParameters.Add("@nomination", nomination);
                    queryParameters.Add("@description", description);
                    queryParameters.Add("@description1", description1);
                    queryParameters.Add("@description2", description2);
                    queryParameters.Add("@property", property);
                    queryParameters.Add("@mandatory", mandatory);
                    queryParameters.Add("@db", db);
                    queryParameters.Add("@file", file);
                    queryParameters.Add("@user_id", user_uid);


                    return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

                }
            }
            catch
            {
                using (IDbConnection conn = new SqlConnection(_constring))
                {
                    string readSp = "select_Error";
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@error_id", error_id);

                    return await conn.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                }

            }
        }

        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> spu_Tip_Info( string tablename, int?uid,int? uid_sup, int? type_uid, string? nomination, string? description
            , string? description1, string? description2, int? property, bool? mandatory, float? queue, bool? file, int? user_uid)
        {

            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_TYPE_INFO";
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

                    if (type_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_TYPE_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@TYPE_UID", type_uid);
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

                    if (property is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_veti", 1);
                    }
                    else
                    {
                        queryParameters.Add("@PROPERTY", property);
                    }
                    if (mandatory is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_MANDATORY", 1);
                    }
                    else
                    {
                        queryParameters.Add("@MANDATORY", mandatory);
                    }
                    if (queue is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_Rradha", 1);
                    }
                    else
                    {
                        queryParameters.Add("@QUEUE", queue);
                    }
               
                    if (file is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_FILE", 1);
                    }
                    else
                    {
                        queryParameters.Add("@FILE", file);
                    }
                  

                    if (user_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@USER_UID", user_uid);
                    }


                return await sql.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

            }


        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectAllActiveRec(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRec";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_TYPE_INFO");
                return await db.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectActiveRecByUID(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_TYPE_INFO");
                queryParameters.Add("@uid", UID);
                return await db.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

       



        public async Task<Boolean> DeleteRow(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName + "_TYPE_INFO");
                queryParameters.Add("@UID", UID);
               await db.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> SelectActiveRecByParameters(string tableName, string? uid_sup, string? nomination, string? description)
        {
           
                using (IDbConnection db = new SqlConnection(_constring))
                {
                    string readSp = "SelectActiveRecByParameters";
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@table", tableName + "_TYPE_INFO");
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

                    return await db.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }



    }
  }

