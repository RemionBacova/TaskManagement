using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_nder_table_kategoriRepository
    {
        private readonly string _constring;
        public sp_tbl_nder_table_kategoriRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_nder_table_kategori(tbl_nder_table_kategoriModel nt, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_nder_" + tablename + "_kategori", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nrrendor", nt.nrrendor));
                    cmd.Parameters.Add(new SqlParameter("@id_gen", nt.id_gen));
                    cmd.Parameters.Add(new SqlParameter("@id_sup", nt.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@id_sup_gen", nt.id_sup_gen));
                    cmd.Parameters.Add(new SqlParameter("@id_ndr", nt.id_ndr));
                    cmd.Parameters.Add(new SqlParameter("@id_ndr_gen", nt.id_ndr_gen));
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_id", nt.table_id));
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_id_gen", nt.table_id_gen));
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_kategori_id", nt.table_kategori_id));
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_kategori_id_gen", nt.table_kategori_id_gen));
                    cmd.Parameters.Add(new SqlParameter("@aktiv", nt.aktiv));
                    cmd.Parameters.Add(new SqlParameter("@perdorues_id", nt.perdorues_id));
                    cmd.Parameters.Add(new SqlParameter("@perdorues_id_gen", nt.perdorues_id_gen));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }

        public async Task spu_nder_table_kategori(tbl_nder_table_kategoriModel nt, string tablename)
        {
            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_nder_" + tablename + "_kategori", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nrrendor", nt.nrrendor));

                    if (nt.id_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", nt.id_sup));
                    }
                    if (nt.id_sup_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup_gen", nt.id_sup_gen));
                    }
                    if (nt.id_ndr is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_ndr", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_id_ndr", nt.id_ndr));
                    }
                    if (nt.id_ndr_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_ndr_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_id_ndr_gen", nt.id_ndr_gen));
                    }
                    if (nt.table_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "_id", nt.table_id));
                    }
                    if (nt.table_id_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_id_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "_id_gen", nt.table_id_gen));
                    }
                    if (nt.table_kategori_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_kategori_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "__kategori_id", nt.table_kategori_id));
                    }
                    if (nt.table_kategori_id_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_kategori_id_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "_kategori_id_gen", nt.table_kategori_id_gen));
                    }
                    if (nt.aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@aktiv", nt.aktiv));
                    }
                    if (nt.perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@perdorues_id", nt.perdorues_id));
                    }
                    if (nt.perdorues_id_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_perdorues_id_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@perdorues_id_gen", nt.perdorues_id_gen));
                    }



                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }
    }
}
