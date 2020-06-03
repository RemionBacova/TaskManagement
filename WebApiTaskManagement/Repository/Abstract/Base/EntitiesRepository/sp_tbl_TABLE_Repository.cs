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
    #region IConfiguration
    public class sp_tbl_TABLE_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }


        #endregion

        #region SPI_TABLE
        public async Task<IEnumerable<tbl_TABLE_Model>> spi_tbl_table(string tableName, int? uid_sup, int? type_uid, string?code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid ,int?category,bool?complex)
        {

            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tableName;
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@uid_sup",  uid_sup);
                queryParameters.Add("@type_uid",  type_uid);
                queryParameters.Add("@code",  code);
                queryParameters.Add("@nomination",  nomination);
                queryParameters.Add("@description",  description);
                queryParameters.Add("@description1",  description1);
                queryParameters.Add("@description2",  description2);
                queryParameters.Add("@user_uid",  user_uid);
                queryParameters.Add("@category",  category);
                queryParameters.Add("@complex",  complex);


                return await sql.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }
        }
        #endregion

        #region SPU_TABLE

        public async Task<IEnumerable<tbl_TABLE_Model>> spu_tbl_table( string tableName, int?uid,int? uid_sup, int? type_uid, string? code, string? nomination, string? description
            , string? description1, string? description2, int? user_uid, int? category, bool? complex)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tableName;
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@UID",  uid);

                if ( uid_sup is null)
                {
                    queryParameters.Add("@CONSIDERNULL_ID_SUP", 1);
                }
                else
                {
                    queryParameters.Add("@UID_SUP",  uid_sup);
                }

                if ( type_uid is null)
                {
                    queryParameters.Add("@CONSIDERNULL_TYPE_ID", 1);
                }
                else
                {
                    queryParameters.Add("@TYPE_UID",  type_uid);
                }
                if ( code is null)
                {
                    queryParameters.Add("@CONSIDERNULL_CODE", 1);
                }
                else
                {
                    queryParameters.Add("@CODE",  code);
                }
                if ( nomination is null)
                {
                    queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                }
                else
                {
                    queryParameters.Add("@NOMINATION",  nomination);
                }
                if ( description is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION",  description);
                }
                if ( description1 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION2",  description1);
                }
                if ( description2 is null)
                {
                    queryParameters.Add("@CONSIDERNULL_DESCRIPTION3", 1);
                }
                else
                {
                    queryParameters.Add("@DESCRIPTION3",  description2);
                }


                if ( user_uid is null)
                {
                    queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                }
                else
                {
                    queryParameters.Add("@USER_UID",  user_uid);
                }


                if ( complex is null)
                {
                    queryParameters.Add("@considerNull_kompleks", 1);
                }
                else
                {
                    queryParameters.Add("@COMPLEX",  complex);
                }



                return await sql.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

        }

        #endregion

        #region SP_SelectAllActiveRec
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectAllActiveRec( string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRec";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SP_SelectByUID

        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByUID(string tableName, string uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName);
                queryParameters.Add("@uid", uid);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SP_SelectByType
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByTYPE(string tableName, string TYPE_UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByType";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName);
                queryParameters.Add("@type_uid", TYPE_UID);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SP_SelectByNomination
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByProperty(string tableName, string? info, string? nomination)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByProperty";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName);
                queryParameters.Add("@typeID", info);
                queryParameters.Add("@nomination", nomination);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region SP_DeleteRow
        public async Task<Boolean> DeleteRow(string tableName, string UID )
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE","tbl_"+tableName);
                queryParameters.Add("@UID", UID);
                await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
        #endregion

        #region SP_SelectByParameters

        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByParameters(string tableName, string? uid_sup, string? nomination, string? description)
        {
            
                using (IDbConnection db = new SqlConnection(_constring))
                {
                    string readSp = "SelectActiveRecByParameters";
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@table", "tbl_" + tableName);
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

                    return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                }
            }
        #endregion

    }
}


