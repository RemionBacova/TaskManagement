using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagemenk.Repository.Base.EntitiesRepository
{
    public class sp_tbl_TABLE_CATEGORY_Repository
    {
        public class TipiRepository
        {
            private readonly string _constring;
            public TipiRepository(IConfiguration configuration)
            {
                _constring = configuration.GetConnectionString("defaultConnection");
            }

            public async Task spi_Kateogria(tbl_TABLE_CATEGORY_Model k,string tablename)
            {
             
               

                using (SqlConnection sql = new SqlConnection(_constring))
                {
                    using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_CATEGORY", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@uid_sup", k.uid_sup));
                        cmd.Parameters.Add(new SqlParameter("@elcat", k.elcat));
                        cmd.Parameters.Add(new SqlParameter("@code", k.code));
                        cmd.Parameters.Add(new SqlParameter("@nomination", k.nomination));
                        cmd.Parameters.Add(new SqlParameter("@description", k.description));
                        cmd.Parameters.Add(new SqlParameter("@description1", k.description1));
                        cmd.Parameters.Add(new SqlParameter("@description2", k.description2));
                        cmd.Parameters.Add(new SqlParameter("@queue", k.queue));
                        cmd.Parameters.Add(new SqlParameter("@user_uid", k.user_uid));

                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return;

                    }
                }
            }



            public async Task spu_Kateogria(tbl_TABLE_CATEGORY_Model k, string tablename)
            {



                using (SqlConnection sql = new SqlConnection(_constring))
                {
                    using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_CATEGORY", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@uid", k.uid));

                        if (k.uid_sup is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_UID_SUP", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@UID_SUP", k.uid_sup));
                        }

                        if (k.elcat is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ELCAT", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@ELCAT", k.elcat));
                        }
                        if (k.code is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_CODE", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@CODE", k.code));
                        }
                       
                        if (k.nomination is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_NOMINATION", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@NOMINATION", k.nomination));
                        }
                        if (k.description is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", k.description));
                        }
                        if (k.description1 is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION1", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@DESCRIPTION1", k.description1));
                        }
                        if (k.description2 is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION2", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@DESCRIPTION2", k.description2));
                        }

                        if (k.active is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ACTIVE", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@ACTIVE", k.active));
                        }

                        if (k.user_uid is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_USER_UID", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@USER_UID", k.user_uid));
                        }


                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return;

                    }
                }
            }






        }
    }
}
