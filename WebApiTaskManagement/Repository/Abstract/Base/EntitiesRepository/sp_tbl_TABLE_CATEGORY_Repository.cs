using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagemenk.Repository.Base.EntitiesRepository
{
    public class sp_tbl_TABLE_CATEGORY_Repository
    {

        private readonly string _constring;
        public sp_tbl_TABLE_CATEGORY_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> spi_Kateogria(tbl_TABLE_CATEGORY_Model k, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename + "_CATEGORY";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@uid_sup", k.uid_sup);
                queryParameters.Add("@elcat", k.elcat);
                queryParameters.Add("@code", k.code);
                queryParameters.Add("@nomination", k.nomination);
                queryParameters.Add("@description", k.description);
                queryParameters.Add("@description1", k.description1);
                queryParameters.Add("@description2", k.description2);
                queryParameters.Add("@queue", k.queue);
                queryParameters.Add("@user_uid", k.user_uid);

                return await sql.QueryAsync<tbl_TABLE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }
        }




        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> spu_Kateogria(tbl_TABLE_CATEGORY_Model k, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_CATEGORY";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@uid", k.uid);

                if (k.uid_sup is null)
                {
                    queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                }
                else
                {
                    queryParameters.Add("@UID_SUP", k.uid_sup);
                }

                if (k.elcat is null)
                {
                    queryParameters.Add("@CONSIDERNULL_ELCAT", 1);
                }
                else
                {
                    queryParameters.Add("@ELCAT", k.elcat);
                }
                if (k.code is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODE", 1);
                }
                else
                {
                    queryParameters.Add("@CODE", k.code);
                }

                if (k.nomination is null)
                {
                    queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                }
                else
                {
                    queryParameters.Add("@NOMINATION", k.nomination);
                }
                if (k.description is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION", k.description);
                }
                if (k.description1 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION2", k.description1);
                }
                if (k.description2 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION3", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION3", k.description2);
                }

                if (k.active is null)
                {
                    queryParameters.Add("@CONSIDERNULL_ACTIVE", 1);
                }
                else
                {
                    queryParameters.Add("@ACTIVE", k.active);
                }

                if (k.user_uid is null)
                {
                    queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                }
                else
                {
                    queryParameters.Add("@USER_UID", k.user_uid);
                }


                return await sql.QueryAsync<tbl_TABLE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }
        }


        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRec(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRec";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_CATEGORY");
                return await db.QueryAsync<tbl_TABLE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRecByUID(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRecByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_CATEGORY");
                queryParameters.Add("@uid", UID);
                return await db.QueryAsync<tbl_TABLE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<Boolean> DeleteRow(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE","tbl_"+ tableName+"_CATEGORY");
                queryParameters.Add("@UID", UID);
               await db.QueryAsync<tbl_TABLE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }

        public async Task<IEnumerable<tbl_TABLE_CATEGORY_Model>> SelectAllActiveRecBySup(string tableName, string? uid_sup, string? active, string? nomination, string? description)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRecBySup";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "_CATEGORY");
                if (uid_sup is null)
                {
                    queryParameters.Add("@uid_sup", "");
                }
                else
                {
                    queryParameters.Add("@uid_sup", uid_sup);
                }

                if (active is null)
                {
                    queryParameters.Add("active", 1);
                }
                else
                {
                    queryParameters.Add("@active", active);
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

                return await db.QueryAsync<tbl_TABLE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }






    }
}



