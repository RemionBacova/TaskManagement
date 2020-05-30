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
    public abstract class sp_tbl_TABLE_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_TABLE_Model>> spi_tbl_table(tbl_TABLE_Model tab, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename;
                var queryParameters = new DynamicParameters();
              
                   queryParameters.Add("@uid_sup", tab.uid_sup);
                   queryParameters.Add("@type_uidd", tab.type_uid);
                   queryParameters.Add("@code", tab.code);
                   queryParameters.Add("@nomination", tab.nomination);
                   queryParameters.Add("@description", tab.description);
                   queryParameters.Add("@description1", tab.description1);
                   queryParameters.Add("@description2", tab.description2);
                   queryParameters.Add("@user_uid", tab.user_uid);
                   queryParameters.Add("@category", tab.category);
                   queryParameters.Add("@complex", tab.complex);


                return await sql.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);


            }
            }
        



        public async Task<IEnumerable<tbl_TABLE_Model>> spu_tbl_table(tbl_TABLE_Model tab, string tablename)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename;
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@UID", tab.uid);

                    if (tab.uid_sup is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_ID_SUP", 1);
                    }
                    else
                    {
                       queryParameters.Add("@UID_SUP", tab.uid_sup);
                    }

                    if (tab.type_uid is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_TYPE_ID", 1);
                    }
                    else
                    {
                       queryParameters.Add("@TYPE_UID", tab.type_uid);
                    }
                    if (tab.code is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_CODE", 1);
                    }
                    else
                    {
                       queryParameters.Add("@CODE", tab.code);
                    }
                    if (tab.nomination is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                    }
                    else
                    {
                       queryParameters.Add("@NOMINATION", tab.nomination);
                    }
                    if (tab.description is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                    }
                    else
                    {
                       queryParameters.Add("@DESCRIPTION", tab.description);
                    }
                    if (tab.description1 is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_DESCRIPTION1", 1);
                    }
                    else
                    {
                       queryParameters.Add("@DESCRIPTION1", tab.description1);
                    }
                    if (tab.description2 is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                    }
                    else
                    {
                       queryParameters.Add("@DESCRIPTION2", tab.description2);
                    }

                   

                    if (tab.active is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_ACTIVE", 1);
                    }
                    else
                    {
                       queryParameters.Add("@ACTIVE", tab.active);
                    }

                    if (tab.user_uid is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                    }
                    else
                    {
                       queryParameters.Add("@USER_UID", tab.user_uid);
                    }

             
                    if (tab.complex is null)
                    {
                       queryParameters.Add("@considerNull_kompleks", 1);
                    }
                    else
                    {
                       queryParameters.Add("@COMPLEX", tab.complex);
                    }



                return await sql.QueryAsync<tbl_TABLE_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

            }

        }
    }

