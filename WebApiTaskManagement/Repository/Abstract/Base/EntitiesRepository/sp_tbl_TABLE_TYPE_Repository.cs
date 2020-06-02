using Dapper;
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
    public  class sp_tbl_TABLE_TYPE_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_TYPE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }
        #region SPI TIP
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> spi_Tipi(tbl_TABLE_TYPE_Model t, string tablename)
        {
            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename + "_TYPE";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@uid_sup", t.uid_sup);
                queryParameters.Add("@elcat", t.elcat);
                queryParameters.Add("@code", t.code);
                queryParameters.Add("@codebegin", t.codebegin);
                queryParameters.Add("@codeend", t.codeend);
                queryParameters.Add("@codeactual", t.codeactual);
                queryParameters.Add("@nomination", t.nomination);
                queryParameters.Add("@description", t.description);
                queryParameters.Add("@description1", t.description1);
                queryParameters.Add("@description2", t.description2);
                queryParameters.Add("@queue", t.queue);
                queryParameters.Add("@user_uid", t.user_uid);

                return await sql.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

        }
        #endregion

        #region SPU TIPI
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> spu_tipi(tbl_TABLE_TYPE_Model t, string tablename)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_TYPE";
                var queryParameters = new DynamicParameters();


                queryParameters.Add("@UID", t.uid);

                if (t.uid_sup is null)
                {
                    queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                }
                else
                {
                    queryParameters.Add("@UID_SUP", t.uid_sup);
                }

                if (t.elcat is null)
                {
                    queryParameters.Add("@CONSIDERNULL_ELCAT", 1);
                }
                else
                {
                    queryParameters.Add("@elcat", t.elcat);
                }
                if (t.code is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODE", 1);
                }
                else
                {
                    queryParameters.Add("@CODE", t.code);
                }
                if (t.codebegin is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODEBEGIN", 1);
                }
                else
                {
                    queryParameters.Add("@CODEBEGIN", t.codebegin);
                }
                if (t.codeend is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODEEND", 1);
                }
                else
                {
                    queryParameters.Add("@CODEEND", t.codeend);
                }
                if (t.codeactual is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODEACTUAL", 1);
                }
                else
                {
                    queryParameters.Add("@CODEACTUA", t.codeactual);
                }
                if (t.nomination is null)
                {
                    queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                }
                else
                {
                    queryParameters.Add("@NOMINATION", t.nomination);
                }
                if (t.description is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION", t.description);
                }
                if (t.description1 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION1", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION1", t.description1);
                }
                if (t.description2 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION2", t.description2);
                }

                if (t.active is null)
                {
                    queryParameters.Add("@CONSIDERNULL_ACTIVE", 1);
                }
                else
                {
                    queryParameters.Add("@ACTIVE", t.active);
                }

                if (t.user_uid is null)
                {
                    queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                }
                else
                {
                    queryParameters.Add("@USER_UID", t.user_uid);
                }


                return await sql.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

        }
        #endregion

        #region SELECT ALL
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectAllActiveRec(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRec";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "TYPE");
                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SELECT BY ID
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByUID(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "TYPE");
                queryParameters.Add("@uid", UID);
                return await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region DELETE ROW
        public async Task<Boolean> DeleteRow(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName + "TYPE");
                queryParameters.Add("@UID", UID);
                await db.QueryAsync<tbl_TABLE_TYPE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
        #endregion

        #region SELECT BY PARAMETERS
        public async Task<IEnumerable<tbl_TABLE_TYPE_Model>> SelectActiveRecByParameters(string tableName, string? uid_sup, string? nomination, string? description)
        {

            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByParameters";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName + "TYPE");
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
        #endregion

    }
}

  

