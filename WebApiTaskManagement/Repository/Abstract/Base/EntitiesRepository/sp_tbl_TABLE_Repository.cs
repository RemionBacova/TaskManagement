using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Controllers.Employees_Controllers;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
  
    public class sp_tbl_TABLE_Repository
    { 
        private readonly string _constring;
        public sp_tbl_TABLE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }


        #region SPI_TABLE
        public async Task<IEnumerable<SelectError_Model>> spi_tbl_table(string tableName, int? uid_sup, int? type_uid, string?code, string? nomination, string? description
            , string? description2, string? description3, int? user_uid ,int?category,bool?complex)
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
                queryParameters.Add("@description2",  description2);
                queryParameters.Add("@description3",  description3);
                queryParameters.Add("@user_uid",  user_uid);
                queryParameters.Add("@category",  category);
                queryParameters.Add("@complex", complex);

                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
               
            }
        }
        #endregion

        #region SPU_TABLE

        public async Task<IEnumerable<SelectError_Model>> spu_tbl_table( string tableName, int?uid,int? uid_sup, int? type_uid, string? code, string? nomination, string? description
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


                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<tbl_TABLE_Model_Calendar>> SelectAllActiveRec_Calendar(string employeeUID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectEmployee_Holiday";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@employee_uid", employeeUID);
                return await db.QueryAsync<tbl_TABLE_Model_Calendar>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
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
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByProperty(string tableName, string? typeID, string? nomination)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByProperty";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName);
                queryParameters.Add("@typeID", typeID);
                queryParameters.Add("@nomination", nomination);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region SP_DeleteRow
        public async Task<IEnumerable<SelectError_Model>> DeleteRow(string tableName, string UID )
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "DeleteRow";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE","tbl_"+tableName);
                queryParameters.Add("@UID", UID);
               return await db.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
              ;
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
                    queryParameters.Add("@table", tableName);
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

        #region SP_SelectByCategory
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectByCategory(string tableName, string? category_uid)
        {
           
                using (IDbConnection db = new SqlConnection(_constring))
                {
                    string readSp = "SelectActiveRecByCategory";
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@table", tableName);
                    queryParameters.Add("@category_uid", category_uid);
                    return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
                }
          }
        #endregion

        #region SP_SelectByCategoryType
        public async Task<IEnumerable<tbl_TABLE_Model>> SelectActiveRecByCategoryAndType(string tableName, string? category_uid,string type_uid)
        {

            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectActiveRecByCategoryAndType";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", tableName);
                queryParameters.Add("@category_uid", category_uid);
                queryParameters.Add("@type_uid", type_uid);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }


        #endregion

        

        #region SP_SelectAllActivByParent
        public async Task<IEnumerable<tbl_TABLE_Model1>> SelectAllActiveRecWithParent(string tableName)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRecWithParent";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table", "tbl_" + tableName );
                return await db.QueryAsync<tbl_TABLE_Model1>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion



        public async Task<IEnumerable<tbl_TABLE_Model>> spGetTree(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "GetTree";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName);
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<tbl_TABLE_Model>> GetPossibleParents(string tableName, string UID)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "GetPossibleParents";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@TABLE", "tbl_" + tableName);
                queryParameters.Add("@UID", UID);
                return await db.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<IEnumerable<tbl_TABLE_Model2>> SelectAllActiveRecPlusType(string tableName,string category)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectAllActiveRecPlusType";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@table",  tableName);
                queryParameters.Add("@category",category);
                return await db.QueryAsync<tbl_TABLE_Model2>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }


    }










}




