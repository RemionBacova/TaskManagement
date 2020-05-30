
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
    public abstract class sp_tbl_TABLE_TYPE_INFO_CH_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_TYPE_INFO_CH_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_CH_Model>> spi_Tip_Info_Ch(tbl_TABLE_TYPE_INFO_CH_Model tich, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_" + tablename + "_TYPE_INFO_CH";
                var queryParameters = new DynamicParameters();
                
                   queryParameters.Add("@uid_sup", tich.uid_sup);
                   queryParameters.Add("@type_info_uid", tich.type_info_uid);
                   queryParameters.Add("@nomination", tich.nomination);
                   queryParameters.Add("@description", tich.description);
                   queryParameters.Add("@description1", tich.description1);
                   queryParameters.Add("@description2", tich.description2);                   
                   queryParameters.Add("@user_uid", tich.user_uid);
                   queryParameters.Add("@VA", tich.VA);


                return await sql.QueryAsync<tbl_TABLE_TYPE_INFO_CH_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }
            }
        

        public async Task<IEnumerable<tbl_TABLE_TYPE_INFO_CH_Model>> spu_Tip_Info_Ch(tbl_TABLE_TYPE_INFO_CH_Model tich, string tablename)
        {


            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spU_tbl_" + tablename + "_TYPE_INFO_CH";
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@UID", tich.uid);

                    if (tich.uid_sup is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_UID_SUP", 1);
                    }
                    else
                    {
                       queryParameters.Add("@UID_SUP", tich.uid_sup);
                    }

                    if (tich.type_info_uid is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_TYPE_INFO_UID", 1);
                    }
                    else
                    {
                       queryParameters.Add("@TYPE_INFO_UID", tich.type_info_uid);
                    }

                    if (tich.nomination is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_NOMINATION", 1);
                    }
                    else
                    {
                       queryParameters.Add("@NOMINATION", tich.nomination);
                    }
                    if (tich.description is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_DESCRIPTION", 1);
                    }
                    else
                    {
                       queryParameters.Add("@DESCRIPTION", tich.description);
                    }
                    if (tich.description1 is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_DESCRIPTION1", 1);
                    }
                    else
                    {
                       queryParameters.Add("@DESCRIPTION1", tich.description1);
                    }
                    if (tich.description2 is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_DESCRIPTION2", 1);
                    }
                    else
                    {
                       queryParameters.Add("@DESCRIPTION2", tich.description2);
                    }

                    if (tich.active is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_ACTIVE", 1);
                    }
                    else
                    {
                       queryParameters.Add("@ACTIVE", tich.active);
                    }

                    if (tich.user_uid is null)
                    {
                       queryParameters.Add("@CONSIDERNULL_USER_UID", 1);
                    }
                    else
                    {
                       queryParameters.Add("@USER_UID", tich.user_uid);
                    }

                return await sql.QueryAsync<tbl_TABLE_TYPE_INFO_CH_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

            }

        }


    }

