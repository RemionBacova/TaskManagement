
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_TABLE_TYPE_INFO_CH_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_TYPE_INFO_CH_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Tip_Info_Ch(tbl_TABLE_TYPE_INFO_CH_Model tich, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_TYPE_INFO_CH", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@uid_sup", tich.uid_sup));
                    cmd.Parameters.Add(new SqlParameter("@type_info_uid", tich.type_info_uid));
                    cmd.Parameters.Add(new SqlParameter("@nomination", tich.nomination));
                    cmd.Parameters.Add(new SqlParameter("@description", tich.description));
                    cmd.Parameters.Add(new SqlParameter("@description1", tich.description1));
                    cmd.Parameters.Add(new SqlParameter("@description2", tich.description2));                   
                    cmd.Parameters.Add(new SqlParameter("@user_uid", tich.user_uid));
                    cmd.Parameters.Add(new SqlParameter("@VA", tich.VA));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }

        public async Task spu_Tip_Info_Ch(tbl_TABLE_TYPE_INFO_CH_Model tich, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_TYPE_INFO_CH", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@UID", tich.uid));

                    if (tich.uid_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_UID_SUP", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@UID_SUP", tich.uid_sup));
                    }

                    if (tich.type_info_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_TYPE_INFO_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@TYPE_INFO_UID", tich.type_info_uid));
                    }

                    if (tich.nomination is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_NOMINATION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@NOMINATION", tich.nomination));
                    }
                    if (tich.description is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", tich.description));
                    }
                    if (tich.description1 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION1", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION1", tich.description1));
                    }
                    if (tich.description2 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION2", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION2", tich.description2));
                    }

                    if (tich.active is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ACTIVE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@ACTIVE", tich.active));
                    }

                    if (tich.user_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_USER_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@USER_UID", tich.user_uid));
                    }

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }


    }
}
