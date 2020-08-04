using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement.Models.Abstract.Base;
using webapiUploadFile.Models;

namespace webapiUploadFile.Repository
{
    public class tbl_FilesRepository
    {

        private readonly string _constring;
        public tbl_FilesRepository(IConfiguration configuration)
        {
            _constring = configuration.GetConnectionString("defaultConnection");
        }


        public async Task<IEnumerable<SelectError_Model>> spi_Files(string entity, string elementID, string typeUID,string url, string file, string file_type)
        {
    

            using (IDbConnection sql = new SqlConnection(_constring))
            {

                string readSp = "UploadFiles";
                var queryParameters = new DynamicParameters();


                queryParameters.Add("@entity", entity);
                queryParameters.Add("@elementID", elementID);
                queryParameters.Add("@typeUID", typeUID);
                queryParameters.Add("@url", url);
                queryParameters.Add("@file", file);
                queryParameters.Add("@file_type", file_type);


                return await sql.QueryAsync<SelectError_Model>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }

        }

        public async Task<IEnumerable<tbl_Files>> SelectFileByUID(string Element_UID, string type_info_uid)
        {
            using (IDbConnection db = new SqlConnection(_constring))
            {
                string readSp = "SelectFileByUID";
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Element_UID", Element_UID);
                queryParameters.Add("@Type_Info_UID", type_info_uid);
                return await db.QueryAsync<tbl_Files>(readSp, queryParameters, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
