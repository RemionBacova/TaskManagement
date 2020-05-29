using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_TABLE_TYPE_INFO_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_TYPE_INFO_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Tip_Info(tbl_TABLE_TYPE_INFO_Model ti, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_TYPE_INFO", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@uid_sup", ti.uid_sup));
                    cmd.Parameters.Add(new SqlParameter("@type_uid", ti.type_uid));
                    cmd.Parameters.Add(new SqlParameter("@nomination", ti.nomination));
                    cmd.Parameters.Add(new SqlParameter("@description", ti.description));
                    cmd.Parameters.Add(new SqlParameter("@description1", ti.description1));
                    cmd.Parameters.Add(new SqlParameter("@description2", ti.description2));
                    cmd.Parameters.Add(new SqlParameter("@property", ti.property));
                    cmd.Parameters.Add(new SqlParameter("@mandatory", ti.mandatory));
                    cmd.Parameters.Add(new SqlParameter("@queue", ti.queue));
                    cmd.Parameters.Add(new SqlParameter("@db", ti.db));
                    cmd.Parameters.Add(new SqlParameter("@file", ti.file));
                    cmd.Parameters.Add(new SqlParameter("@user_uid", ti.user_uid));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }


        public async Task spu_Tip_Info(tbl_TABLE_TYPE_INFO_Model ti, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_TYPE_INFO", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@UID", ti.uid));

                    if (ti.uid_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_UID_SUP", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@UID_SUP", ti.uid_sup));
                    }

                    if (ti.type_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_TYPE_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@tip_id", ti.type_uid));
                    }

                    if (ti.nomination is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_NOMINATION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@NOMINATION", ti.nomination));
                    }
                    if (ti.description is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", ti.description));
                    }
                    if (ti.description1 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION1", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION1", ti.description1));
                    }
                    if (ti.description2 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION2", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION2", ti.description2));
                    }

                    if (ti.property is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_PROPERTY", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@PROPERTY", ti.property));
                    }
                    if (ti.mandatory is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_MANDATORY", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@MANDATORY", ti.mandatory));
                    }
                    if (ti.queue is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_QUEUE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@QUEUE", ti.queue));
                    }
               
                    if (ti.file is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_FILE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@FILE", ti.file));
                    }
                    if (ti.active is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ACTIVE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@ACTIVE", ti.active));
                    }

                    if (ti.user_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_USER_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@USER_UID", ti.user_uid));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }




    }
}
