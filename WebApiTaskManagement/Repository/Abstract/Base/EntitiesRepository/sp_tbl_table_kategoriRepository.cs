using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagemenk.Repository.Base.EntitiesRepository
{
    public class sp_tbl_table_kategoriRepository
    {
        public class TipiRepository
        {
            private readonly string _constring;
            public TipiRepository(IConfiguration configuration)
            {
                _constring = configuration.GetConnectionString("defaultConnection");
            }

            public async Task spi_Kateogria(tbl_table_kategoriModel k,string tablename)
            {
             
               

                using (SqlConnection sql = new SqlConnection(_constring))
                {
                    using (SqlCommand cmd = new SqlCommand("spI_tbl_" + tablename + "_kategori", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id_sup", k.id_sup));
                        cmd.Parameters.Add(new SqlParameter("@elcat", k.elcat));
                        cmd.Parameters.Add(new SqlParameter("@kodi", k.kodi));
                        cmd.Parameters.Add(new SqlParameter("@Emertimi", k.Emertimi));
                        cmd.Parameters.Add(new SqlParameter("@pershkrimi", k.pershkrimi));
                        cmd.Parameters.Add(new SqlParameter("@Emertimiang", k.Emertimiang));
                        cmd.Parameters.Add(new SqlParameter("@pershkrimiang", k.pershkrimiang));
                        cmd.Parameters.Add(new SqlParameter("@rradha", k.rradha));
                        cmd.Parameters.Add(new SqlParameter("@Perdorues_id", k.Perdorues_id));

                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return;

                    }
                }
            }



            public async Task spu_Kateogria(tbl_table_kategoriModel k, string tablename)
            {



                using (SqlConnection sql = new SqlConnection(_constring))
                {
                    using (SqlCommand cmd = new SqlCommand("spU_tbl_" + tablename + "_kategori", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nrrendor", k.nrrendor));

                        if (k.id_sup is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@id_sup", k.id_sup));
                        }

                        if (k.elcat is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_elcat", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@elcat", k.elcat));
                        }
                        if (k.kodi is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_kodi", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@kodi", k.kodi));
                        }
                       
                        if (k.Emertimi is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimi", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@Emertimi", k.Emertimi));
                        }
                        if (k.pershkrimi is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimi", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@pershkrimi", k.pershkrimi));
                        }
                        if (k.Emertimiang is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Emertimiang", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@Emertimiang", k.Emertimiang));
                        }
                        if (k.pershkrimiang is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_pershkrimiang", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@pershkrimiang", k.pershkrimiang));
                        }

                        if (k.Aktiv is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Aktiv", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@Aktiv", k.Aktiv));
                        }

                        if (k.Perdorues_id is null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@ConsiderNull_Perdorues_id", 1));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@Perdorues_id", k.Perdorues_id));
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
