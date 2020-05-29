using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task spi_tbl_table(tbl_TABLE_Model tab, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename , sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@uid_sup", tab.uid_sup));
                    cmd.Parameters.Add(new SqlParameter("@type_uidd", tab.type_uid));
                    cmd.Parameters.Add(new SqlParameter("@code", tab.code));
                    cmd.Parameters.Add(new SqlParameter("@nomination", tab.nomination));
                    cmd.Parameters.Add(new SqlParameter("@description", tab.description));
                    cmd.Parameters.Add(new SqlParameter("@description1", tab.description1));
                    cmd.Parameters.Add(new SqlParameter("@description2", tab.description2));
                    cmd.Parameters.Add(new SqlParameter("@user_uid", tab.user_uid));
                    cmd.Parameters.Add(new SqlParameter("@category", tab.category));
                    cmd.Parameters.Add(new SqlParameter("@complex", tab.complex));



                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }
            }
        }



        public async Task spu_tbl_table(tbl_TABLE_Model tab, string tablename)
        {


            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename, sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@UID", tab.uid));

                    if (tab.uid_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ID_SUP", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@UID_SUP", tab.uid_sup));
                    }

                    if (tab.type_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_TYPE_ID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@TYPE_UID", tab.type_uid));
                    }
                    if (tab.code is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_CODE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@CODE", tab.code));
                    }
                    if (tab.nomination is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_NOMINATION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@NOMINATION", tab.nomination));
                    }
                    if (tab.description is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", tab.description));
                    }
                    if (tab.description1 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION1", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION1", tab.description1));
                    }
                    if (tab.description2 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION2", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION2", tab.description2));
                    }

                   

                    if (tab.active is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ACTIVE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@ACTIVE", tab.active));
                    }

                    if (tab.user_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_USER_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@USER_UID", tab.user_uid));
                    }

             
                    if (tab.complex is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@considerNull_kompleks", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@COMPLEX", tab.complex));
                    }



                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }
    }
}
