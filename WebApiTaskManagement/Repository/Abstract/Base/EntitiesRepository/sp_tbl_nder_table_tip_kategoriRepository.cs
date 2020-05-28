using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public class sp_tbl_nder_table_tip_kategoriRepository
    {
        private readonly string _constring;
        public sp_tbl_nder_table_tip_kategoriRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task spi_nder_tip_kateogori(tbl_nder_table_tip_kategoriModel ntk, string tablename)
        {



            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spI_tbl_nder_" + tablename + "_tip_kategori", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_sup", ntk.id_sup));
                    cmd.Parameters.Add(new SqlParameter("@" +tablename+"_tip_id", ntk.table_tip_id));
                    cmd.Parameters.Add(new SqlParameter("@" + tablename + "_tip_kategori_id", ntk.table_tip_kategori_id));
                    cmd.Parameters.Add(new SqlParameter("@perdorues_id", ntk.perdorues_id));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }
        }

        public async Task spu_nder_tip_kateogori(tbl_nder_table_tip_kategoriModel ntk, string tablename)
        {
            using (SqlConnection sql = new SqlConnection(_constring))
            {
                using (SqlCommand cmd = new SqlCommand("spU_tbl_nder_" + tablename + "_tip_kategori", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nrrendor", ntk.nrrendor));

                    if (ntk.id_sup is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup", ntk.id_sup));
                    }
                    if (ntk.id_sup_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_id_sup_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@id_sup_gen", ntk.id_sup_gen));
                    }
                    if (ntk.table_tip_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_"+tablename+"_tip_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "_tip_id", ntk.table_tip_id));
                    }
                    if (ntk.table_tip_id_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_tip_id_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "_tip_id_gen", ntk.table_tip_id_gen));
                    }
                    if (ntk.table_tip_kategori_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_tip_kategori_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@"+tablename + "_tip_kategori_id", ntk.table_tip_kategori_id));
                    }
                    if (ntk.table_tip_kategori_id_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_" + tablename + "_tip_kategori_id_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tablename + "_tip_kategori_id_gen", ntk.table_tip_kategori_id_gen));
                    }
                    if (ntk.aktiv is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_aktiv", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@aktiv", ntk.aktiv));
                    }
                    if (ntk.perdorues_id is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_perdorues_id", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@perdorues_id", ntk.perdorues_id));
                    }
                    if (ntk.perdorues_id_gen is null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@ConsiderNull_perdorues_id_gen", 1));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@perdorues_id_gen", ntk.perdorues_id_gen));
                    }



                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;

                }

            }

        }







        }
    }
