using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract;
using WebApiTaskManagement.Models.Abstract.Base;

namespace WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository
{
    public abstract class sp_tbl_INTER_TABLE_TYPE_CATEGORY_Repository
    {
        private readonly string _constring;
        public sp_tbl_INTER_TABLE_TYPE_CATEGORY_Repository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<IEnumerable<tbl_INTER_TABLE_TYPE_CATEGORY_Model>> spi_nder_tip_kateogori(tbl_INTER_TABLE_TYPE_CATEGORY_Model ntk, string tablename)
        {



            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "spI_tbl_INTER_"+tablename+"_TYPE_CATEGORY";
                var queryParameters = new DynamicParameters();
               
                  
                    queryParameters.Add("@" +tablename+"_type_uid", ntk.table_type_uid);
                    queryParameters.Add("@" + tablename + "_type_category_uid", ntk.table_type_category_uid);
                    queryParameters.Add("@user_uid", ntk.user_uid);


                return await sql.QueryAsync<tbl_INTER_TABLE_TYPE_CATEGORY_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);

            }

            }
        }

       







        }
    
