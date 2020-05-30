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
    public abstract class sp_tbl_TABLE_INFO_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_INFO_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> spi_Info(tbl_TABLE_INFO_Model i, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_"+tablename+"_INFO";
                var queryParameters = new DynamicParameters();
                
                    queryParameters.Add("@uid_sup", i.uid_sup);
                    queryParameters.Add("@element_uid", i.element_uid);
                    queryParameters.Add("@type_info_uid", i.type_info_uid);
                    queryParameters.Add("@nomination", i.nomination);
                    queryParameters.Add("@description", i.description);
                    queryParameters.Add("@description1", i.description1);
                    queryParameters.Add("@description2", i.description2);
                    queryParameters.Add("@user_uid", i.user_uid);

                return await sql.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }

            }
        


        public async Task<IEnumerable<tbl_TABLE_INFO_Model>> spu_Info(tbl_TABLE_INFO_Model i, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_INFO";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@UID", i.uid);

                    if (i.uid_sup is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                    }
                    else
                    {
                        queryParameters.Add("@UID_SUP", i.uid_sup);
                    }

                    if (i.element_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_ELEMENT_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@ELEMENT_UID", i.element_uid);
                    }
                    if (i.type_info_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_TYPE_INFO_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@TYPE_INFO_UID", i.type_info_uid);
                    }

                    if (i.nomination is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                    }
                    else
                    {
                        queryParameters.Add("@NOMINATION", i.nomination);
                    }
                    if (i.description is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION", i.description);
                    }
                    if (i.description1 is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION1", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION1", i.description1);
                    }
                    if (i.description2 is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                    }
                    else
                    {
                        queryParameters.Add("@DESCRIPTION2", i.description2);
                    }

                    if (i.active is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_ACTIVE", 1);
                    }
                    else
                    {
                        queryParameters.Add("@ACTIVE", i.active);
                    }

                    if (i.user_uid is null)
                    {
                        queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                    }
                    else
                    {
                        queryParameters.Add("@USER_UID", i.user_uid);
                    }

                return await sql.QueryAsync<tbl_TABLE_INFO_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }

            }

        }




    }

