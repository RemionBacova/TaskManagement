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
    public  abstract class sp_tbl_TABLE_TYPE_INFO_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_TYPE_INFO_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> spi_Tip_Info(tbl_TABLE_TYPE_INFO_Model ti, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename + "_TYPE_INFO";
                var queryParameters = new DynamicParameters();

                    queryParameters.Add("@uid_sup", ti.uid_sup);
                    queryParameters.Add("@type_uid", ti.type_uid);
                    queryParameters.Add("@nomination", ti.nomination);
                    queryParameters.Add("@description", ti.description);
                    queryParameters.Add("@description1", ti.description1);
                    queryParameters.Add("@description2", ti.description2);
                    queryParameters.Add("@property", ti.property);
                    queryParameters.Add("@mandatory", ti.mandatory);
                    queryParameters.Add("@queue", ti.queue);
                    queryParameters.Add("@db", ti.db);
                    queryParameters.Add("@file", ti.file);
                    queryParameters.Add("@user_uid", ti.user_uid);


                return await sql.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }
            }
        


        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_Model>> spu_Tip_Info(tbl_TABLE_TYPE_INFO_Model ti, string tablename)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_TYPE_INFO";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@UID", ti.uid);

                    if (ti.uid_sup is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                    }
                    else
                    {
                        queryParameters.Add("@UID_SUP", ti.uid_sup);
                    }

                    if (ti.type_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_TYPE_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@tip_id", ti.type_uid);
                    }

                    if (ti.nomination is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                    }
                    else
                    {
                        queryParameters.Add("@NOMINATION", ti.nomination);
                    }
                    if (ti.description is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION", ti.description);
                    }
                    if (ti.description1 is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION1", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION1", ti.description1);
                    }
                    if (ti.description2 is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION2", ti.description2);
                    }

                    if (ti.property is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_PROPERTY", 1);
                    }
                    else
                    {
                        queryParameters.Add("@PROPERTY", ti.property);
                    }
                    if (ti.mandatory is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_MANDATORY", 1);
                    }
                    else
                    {
                        queryParameters.Add("@MANDATORY", ti.mandatory);
                    }
                    if (ti.queue is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_QUEUE", 1);
                    }
                    else
                    {
                        queryParameters.Add("@QUEUE", ti.queue);
                    }
               
                    if (ti.file is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_FILE", 1);
                    }
                    else
                    {
                        queryParameters.Add("@FILE", ti.file);
                    }
                    if (ti.active is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_ACTIVE", 1);
                    }
                    else
                    {
                        queryParameters.Add("@ACTIVE", ti.active);
                    }

                    if (ti.user_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@USER_UID", ti.user_uid);
                    }


                return await sql.QueryAsync<tbl_TABLE_TYPE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

            }

        }




    }

