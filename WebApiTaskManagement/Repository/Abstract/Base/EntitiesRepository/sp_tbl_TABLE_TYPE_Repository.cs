using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Base.EntitiesRepository
{
    public class sp_tbl_TABLE_TYPE_Repository
    {
        private readonly string _constring;
        public sp_tbl_TABLE_TYPE_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_Tipi(tbl_TABLE_TYPE_Model t,string tablename)
        {
           
          

            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@uid_sup", t.uid_sup));
                    cmd.Parameters.Add(new SqlParameter("@elcat", t.elcat));
                    cmd.Parameters.Add(new SqlParameter("@code", t.code));
                    cmd.Parameters.Add(new SqlParameter("@codebegin",t.codebegin));
                    cmd.Parameters.Add(new SqlParameter("@codeend",t.codeend));
                    cmd.Parameters.Add(new SqlParameter("@codeactual",t.codeactual));
                    cmd.Parameters.Add(new SqlParameter("@nomination",t.nomination));
                    cmd.Parameters.Add(new SqlParameter("@description", t.description));
                    cmd.Parameters.Add(new SqlParameter("@description1", t.description1));
                    cmd.Parameters.Add(new SqlParameter("@description2", t.description2));
                    cmd.Parameters.Add(new SqlParameter("@queue", t.queue));
                    cmd.Parameters.Add(new SqlParameter("@user_uid", t.user_uid));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }


      
        public async Task spu_tipi(tbl_TABLE_TYPE_Model t, string tablename)
        {
          
        
            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@UID", t.uid));
                    
                    if (t.uid_sup is null ) {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_UID_SUP", 1));
                    }
                    else {
                        cmd.Parameters.Add(new SqlParameter("@UID_SUP", t.uid_sup));
                    }
                  
                    if (t.elcat is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ELCAT", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@elcat", t.elcat));
                    }
                    if (t.code is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_CODE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@CODE", t.code));
                    }
                    if (t.codebegin is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_CODEBEGIN", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@CODEBEGIN", t.codebegin));
                    }
                    if (t.codeend is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_CODEEND", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@CODEEND", t.codeend));
                    }
                    if (t.codeactual is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_CODEACTUAL", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@CODEACTUA", t.codeactual));
                    }
                    if (t.nomination is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_NOMINATION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@NOMINATION", t.nomination));
                    }
                    if (t.description is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", t.description));
                    }
                    if (t.description1 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION1", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION1", t.description1));
                    }
                    if (t.description2 is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_DESCRIPTION2", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@DESCRIPTION2", t.description2));
                    }

                    if (t.active is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_ACTIVE", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@ACTIVE", t.active));
                    }

                    if (t.user_uid is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@CONSIDERNULL_USER_UID", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@USER_UID", t.user_uid));
                    }


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }
    }
}
