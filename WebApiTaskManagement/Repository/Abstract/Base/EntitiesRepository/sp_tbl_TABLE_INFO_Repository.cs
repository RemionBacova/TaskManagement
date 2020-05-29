using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_TABLE_INFO_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_INFO_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Info(tbl_TABLE_INFO_Model i, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_INFO", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@uid_sup", i.uid_sup));
                    cmd.Parameters.Add(new SqlParameter("@element_uid", i.element_uid));
                    cmd.Parameters.Add(new SqlParameter("@type_info_uid", i.type_info_uid));
                    cmd.Parameters.Add(new SqlParameter("@nomination", i.nomination));
                    cmd.Parameters.Add(new SqlParameter("@description", i.description));
                    cmd.Parameters.Add(new SqlParameter("@description1", i.description1));
                    cmd.Parameters.Add(new SqlParameter("@description2", i.description2));
                    cmd.Parameters.Add(new SqlParameter("@user_uid", i.user_uid));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }


        public async Task spu_Info(tbl_TABLE_INFO_Model i, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_INFO", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@UID", i.uid));

                    if (i.uid_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_UID_SUP", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@UID_SUP", i.uid_sup));
                    }

                    if (i.element_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ELEMENT_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@ELEMENT_UID", i.element_uid));
                    }
                    if (i.type_info_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_TYPE_INFO_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@TYPE_INFO_UID", i.type_info_uid));
                    }

                    if (i.nomination is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_NOMINATION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@NOMINATION", i.nomination));
                    }
                    if (i.description is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", i.description));
                    }
                    if (i.description1 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION1", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION1", i.description1));
                    }
                    if (i.description2 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION2", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION2", i.description2));
                    }

                    if (i.active is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ACTIVE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@ACTIVE", i.active));
                    }

                    if (i.user_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_USER_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@USER_UID", i.user_uid));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }




    }
}
